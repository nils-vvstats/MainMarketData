using Application.Commands;
using Application.Commands.YoHero.SaveAuctions;
using Core.Auctions;
using Core.Auctions.YoHeroLiveAuctions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YoHeroMarketData.Models.MarketData;
using YoHeroMarketData.Translators;

namespace YoHeroMarketData.Requests.LiveAuctionsRequest
{
    public class YoHeroMarketDataRequest
    {
        private static HttpClient client = new HttpClient();
        private readonly ICommandProcessor _commandProcessor;

        public YoHeroMarketDataRequest(ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }
        public async Task<List<YoHeroLiveAuction>> getLatestMarketData()
        {
            //send request for data
            
            var liveAuctions = sendRequests();
            //convert request data into usable data


            var saveLiveAuctionsCommand = new SaveLiveAuctionsCommand(liveAuctions);
            await _commandProcessor.Process(saveLiveAuctionsCommand);

            return liveAuctions;
            //create command to add new auctions
            //execute command

            //return

          
        }

        private  List<YoHeroLiveAuction> sendRequests()
        {
            var firstRequest = sendMarketDataRequest(1).Result;

            var pageSize = firstRequest["pageSize"].ToObject<double>();
            var total = firstRequest["total"].ToObject<double>();


           var liveAuctions = sendAllMarketDataRequest(pageSize, total).Result;


            return liveAuctions;
            //sendAllMarketDataRequest(24, 1000);
        }

        private async Task<List<YoHeroLiveAuction>> sendAllMarketDataRequest(double pageSize, double total)
        {
            var pages = (total / pageSize);
            var numOfPages = (int)Math.Ceiling(pages);

            var liveAuctions = new List<YoHeroLiveAuction>();



            var pagesList = Enumerable.Range(1, numOfPages).ToList();

            var tasks = pagesList.Select(page => YoHeroLiveAuctionTranslator.ToYoHeroLiveAuctions(sendMarketDataRequest(page).Result));

            var marketData = (await Task.WhenAll(tasks)).SelectMany(x => x).ToList();



            //for (int i = 1; i < numOfPages; i++)
            //{
            //    //var data = sendMarketDataRequest(i).ConfigureAwait(false);
            //    //var newAuctions = YoHeroLiveAuctionTranslator.ToYoHeroLiveAuctions(data);

            //    liveAuctions.AddRange(newAuctions);
            //}

            return marketData;

        }

        private async Task<JObject> sendMarketDataRequest(int page)
        {
            var marketDataMessage = new MarketDataMessage(page);
           var marketDataBodyRequest = new MarketDataBodyRequest(marketDataMessage);

            var uri = "https://www.yohero.fi/api";
            var jsonBody = JsonConvert.SerializeObject(marketDataBodyRequest);


            var response = await client.PostAsync(uri, new StringContent(jsonBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);


            var result = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

            var message = result["message"];

            var data = (JObject)JsonConvert.DeserializeObject(message.ToString());

            return data;
        }
    }
}

using Application.Commands;
using Application.Commands.YoHero.SaveAuctions;
using Application.Queries;
using Application.Queries.LiveAuctions;
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
        private readonly IQueryProcessor _queryProcessor;


        public YoHeroMarketDataRequest(ICommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }
        public async Task<List<YoHeroLiveAuction>> getLatestMarketData()
        {
            //send request for data

            var liveAuctions = sendRequests();
            //convert request data into usable data



            //get list of auctions from repo
            var getLiveAuctionsQuery = new GetYoHeroLiveAuctionsQuery();
            var savedLiveAuctions = await _queryProcessor.Process(getLiveAuctionsQuery).ConfigureAwait(false);
            var test = "testl";

            var firstNotSecond = savedLiveAuctions.Except(liveAuctions).ToList();
            var secondNotFirst = liveAuctions.Except(savedLiveAuctions).ToList();


            var deleteLiveAuctionsCommand = new DeleteLiveAuctionCommand(firstNotSecond);
            await _commandProcessor.Process(deleteLiveAuctionsCommand).ConfigureAwait(false);


            //compare two lists

            //delete everything that is not in the list from repo
            //add everything that is in list










            var saveLiveAuctionsCommand = new SaveLiveAuctionsCommand(secondNotFirst);
            await _commandProcessor.Process(saveLiveAuctionsCommand).ConfigureAwait(false);






            //return null;
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

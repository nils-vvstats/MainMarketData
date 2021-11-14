using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YoHeroMarketData.Models.HeroData;

namespace YoHeroMarketData.Requests.HeroAPIRequest
{
    //public class HeroApiRequest
    //{
    //    private static HttpClient client = new HttpClient();

    //    private async Task<JObject> getHeroApiRequest(int page)
    //    {
    //        var heroDataMessage = new HeroDataMessage(page);
    //        var marketDataBodyRequest = new HeroDataBodyRequest(heroDataMessage);

    //        var uri = "https://www.yohero.fi/api";
    //        var jsonBody = JsonConvert.SerializeObject(marketDataBodyRequest);


    //        var response = await client.PostAsync(uri, new StringContent(jsonBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
    //        var test = response.Content;


    //        var result = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

    //        var message = result["message"];

    //        var data = (JObject)JsonConvert.DeserializeObject(message.ToString());


    //        return data;
    //    }
    //}
}

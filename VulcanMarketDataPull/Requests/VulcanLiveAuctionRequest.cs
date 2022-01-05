using Browser.Types;
using Core.Auctions.VulcanAuctions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VulcanMarketDataPull.Models;

namespace VulcanMarketDataPull.Requests
{
    //public class VulcanLiveAuctionRequest
    //{
    //    public VulcanLiveAuctionRequest()
    //    {
    //        var newAuctions = getLiveMarketData();

    //        if (newAuctions == null)
    //        {
    //            return;
    //        }
    //        //query existing auctions
    //        //find all matching auctions 
    //        //update matching auctions
            
    //        //find any auctions not in database
    //        //add them
    //    }

    //    private List<VulcanAuction> getLiveMarketData()
    //    {

    //        var getBaseMarketData = LiveAuctionsRequest.sendMarketDataPost(1, DateTime.Now.AddMonths(-6), DateTime.Now);

    //        if (getBaseMarketData.IsSuccessful)
    //        {
    //            try
    //            {
    //                var data = getBaseMarketData.Content;

    //                var numberOfRecords = JObject.Parse(data)["recordsFiltered"].ToObject<int>();

    //                var marketDataRequest = LiveAuctionsRequest.sendMarketDataPost(numberOfRecords, DateTime.Now.AddMonths(-6), DateTime.Now);

    //                var vulcanAuctions = ConvertToVulcanAuction(marketDataRequest);

    //                return vulcanAuctions;
    //            } catch (Exception ex)
    //            {
    //                //log exception
    //            }

    //        }

    //        return null;

    //    }


    //    private List<VulcanAuction> ConvertToVulcanAuction(IRestResponse request)
    //    {
    //        if (request.IsSuccessful)
    //        {
    //            var data = request.Content;
    //            var jdata = JObject.Parse(data)["data"].ToList();
    //            var newAuctions = LiveAuctionsTranslator.ConvertToVulcanAuctions(jdata);
    //            return newAuctions;
    //        }

    //        return null;
    //    }

    //}
}

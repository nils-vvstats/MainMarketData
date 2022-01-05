using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulcanMarketDataPull.Models
{
    public static class LiveAuctionsRequest
    {

        public static IRestResponse sendMarketDataPost(int length, DateTime startDate, DateTime endTime)
        {





            var client = new RestClient("https://market.vulcanforged.com/MarketActivity/Generate_TableOpenAuctions_DataTable");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("draw", " 1");
            request.AddParameter("columns[0][data]", " CreatedDate");
            request.AddParameter("columns[0][name]", " ");
            request.AddParameter("columns[0][searchable]", " true");
            request.AddParameter("columns[0][orderable]", " true");
            request.AddParameter("columns[0][search][value]", " ");
            request.AddParameter("columns[0][search][regex]", " false");
            request.AddParameter("columns[1][data]", " Title");
            request.AddParameter("columns[1][name]", " ");
            request.AddParameter("columns[1][searchable]", " true");
            request.AddParameter("columns[1][orderable]", " true");
            request.AddParameter("columns[1][search][value]", " ");
            request.AddParameter("columns[1][search][regex]", " false");
            request.AddParameter("columns[2][data]", " ExpiryDate");
            request.AddParameter("columns[2][name]", " ");
            request.AddParameter("columns[2][searchable]", " true");
            request.AddParameter("columns[2][orderable]", " true");
            request.AddParameter("columns[2][search][value]", " ");
            request.AddParameter("columns[2][search][regex]", " false");
            request.AddParameter("columns[3][data]", " BidStartingPrice");
            request.AddParameter("columns[3][name]", " ");
            request.AddParameter("columns[3][searchable]", " true");
            request.AddParameter("columns[3][orderable]", " true");
            request.AddParameter("columns[3][search][value]", " ");
            request.AddParameter("columns[3][search][regex]", " false");
            request.AddParameter("columns[4][data]", " BuyNowPrice");
            request.AddParameter("columns[4][name]", " ");
            request.AddParameter("columns[4][searchable]", " true");
            request.AddParameter("columns[4][orderable]", " true");
            request.AddParameter("columns[4][search][value]", " ");
            request.AddParameter("columns[4][search][regex]", " false");
            request.AddParameter("columns[5][data]", " MinBidPrice");
            request.AddParameter("columns[5][name]", " ");
            request.AddParameter("columns[5][searchable]", " true");
            request.AddParameter("columns[5][orderable]", " true");
            request.AddParameter("columns[5][search][value]", " ");
            request.AddParameter("columns[5][search][regex]", " false");
            request.AddParameter("columns[6][data]", " AuctionID");
            request.AddParameter("columns[6][name]", " ");
            request.AddParameter("columns[6][searchable]", " true");
            request.AddParameter("columns[6][orderable]", " false");
            request.AddParameter("columns[6][search][value]", " ");
            request.AddParameter("columns[6][search][regex]", " false");
            request.AddParameter("columns[7][data]", " AuctionID");
            request.AddParameter("columns[7][name]", " ");
            request.AddParameter("columns[7][searchable]", " true");
            request.AddParameter("columns[7][orderable]", " false");
            request.AddParameter("columns[7][search][value]", " ");
            request.AddParameter("columns[7][search][regex]", " false");
            request.AddParameter("order[0][column]", " 0");
            request.AddParameter("order[0][dir]", " desc");
            request.AddParameter("start", " 0");
            request.AddParameter("length", " " + length);
            request.AddParameter("search[value]", " ");
            request.AddParameter("search[regex]", " false");
            request.AddParameter("DappID[]", " 3");
            request.AddParameter("DappID[]", " 8");
            request.AddParameter("DappID[]", " 10");
            request.AddParameter("DappID[]", " 11");
            request.AddParameter("StartDate", " " + ConvertToVFTime(startDate));
            request.AddParameter("EndDate", " " + ConvertToVFTime(endTime));
            IRestResponse response = client.Execute(request);

            return response;
        }

        private static string ConvertToVFTime(DateTime time)
        {
            var year = time.Year;
            var month = time.Month;
            var day = time.Day;
            var timeOfDay = time.TimeOfDay;



            return year + "-" + month + "-" + day + " " + timeOfDay;
        }
    }
}

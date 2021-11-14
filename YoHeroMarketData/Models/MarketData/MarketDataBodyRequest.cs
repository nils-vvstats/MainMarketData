using System;
using System.Collections.Generic;
using YoHeroMarketData.Models;
using YoHeroMarketData.Models.MarketData;

namespace YoHeroMarketData
{
    public class MarketDataBodyRequest : IBodyRequest
    {
        public MarketDataBodyRequest(MarketDataMessage marketDataMessage)
        {
            message = marketDataMessage;
        }
        public int code => 1096;
        public string playerId => "";
        public IMessage message { get; }
            
    }


}

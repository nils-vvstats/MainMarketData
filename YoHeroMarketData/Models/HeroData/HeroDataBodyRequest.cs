using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoHeroMarketData.Models.HeroData
{
    public class HeroDataBodyRequest : IBodyRequest
    {
        public HeroDataBodyRequest(HeroDataMessage heroDataMessage)
        {
            message = heroDataMessage;
        }
        public int code => 1097;

        public string playerId => "";

        public IMessage message { get; }

    }
}

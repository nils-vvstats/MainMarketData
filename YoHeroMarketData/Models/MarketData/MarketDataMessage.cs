using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoHeroMarketData.Models.MarketData
{
    public class MarketDataMessage : IMessage
    {
        public MarketDataMessage(int page)
        {
            this.page = page;
        }
        public List<string> occns => new List<string>();
        public int minCallNum => 0;
        public int maxCallNum => 7;
        public int order => 4;
        public int page { get; set; }
    }
}

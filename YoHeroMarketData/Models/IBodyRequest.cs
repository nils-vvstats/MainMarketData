using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoHeroMarketData.Models
{
    public interface IBodyRequest
    {
        public int code { get; }
        public string playerId { get; }
        public IMessage message { get; }
    }
}

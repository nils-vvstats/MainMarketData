using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoHeroMarketData.Models.HeroData
{
    public class HeroDataMessage : IMessage
    {
        public HeroDataMessage(int id)
        {
            petId = id;
        }
        public int petId { get; }

    }
}

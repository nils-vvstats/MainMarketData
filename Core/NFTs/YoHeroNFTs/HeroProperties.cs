using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class HeroProperties : NFTProperties
    {
        public Race Race { get; set; }
        public int NumberOfSummons { get; set; }
        public HeroAttributes HeroAttributes { get; set; }
        public HeroComposition HeroComposition { get; set; }

    }
}

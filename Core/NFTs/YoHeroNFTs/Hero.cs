using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class Hero : NFT
    {
        public int ID { get; set; }
        public HeroProperties Properties { get; set; }
        public int? Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class Hero : NFT
    {
        public Hero() {}
        public Hero(int id, HeroProperties heroProperties)
        {
            ID = id;
            HeroProperties = heroProperties;
        }
        public int ID { get; set; }
        public HeroProperties HeroProperties { get; set; }
    }
}

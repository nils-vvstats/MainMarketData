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
            Id = Guid.NewGuid();
            HeroID = id;
            HeroProperties = heroProperties;
        }
        public Guid Id { get; }
        public int HeroID { get; set; }
        public HeroProperties HeroProperties { get; set; }
    }
}

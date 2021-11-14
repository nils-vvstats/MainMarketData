using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class HeroProperties : NFTProperties
    {
        public HeroProperties() { }
        public HeroProperties(Race race, int numOfSummons, HeroAttributes heroAttributes, HeroComposition heroComposition, bool genesisHero)
        {
            Id = Guid.NewGuid();
            Race = race;
            NumberOfSummons = numOfSummons;
            HeroAttributes = heroAttributes;
            HeroComposition = heroComposition;
            GenesisHero = genesisHero;
        }

        public Guid Id { get; }
        public Race Race { get; }
        public int NumberOfSummons { get; }
        public HeroAttributes HeroAttributes { get; }
        public HeroComposition HeroComposition { get; }
        public bool GenesisHero { get; }

    }
}

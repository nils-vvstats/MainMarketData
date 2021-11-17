using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            Race = race;
            NumberOfSummons = numOfSummons;
            HeroAttributes = heroAttributes;
            HeroComposition = heroComposition;
            GenesisHero = genesisHero;
        }

        public Race Race { get; }
        public int NumberOfSummons { get; }
        public virtual HeroAttributes HeroAttributes { get; }
        public virtual HeroComposition HeroComposition { get; }
        public bool GenesisHero { get; }

    }
}

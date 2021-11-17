using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class HeroAttributes
    {
        public HeroAttributes() { }
        public HeroAttributes(int hp, int att, int spo, int dex, int crit)
        {
            HP = hp;
            ATT = att;
            SPO = spo;
            DEX = dex;
            CRIT = crit;
        }
        public int HP { get; }
        public int ATT { get; }
        public int SPO { get; }
        public int DEX { get;}
        public int CRIT { get; }
    }
}

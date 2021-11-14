using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public enum Race
    {
        Qi = 1,
        Shaman = 2,
        Knight = 3,
        Warrior = 4,
        Priest = 5,
        Warlock = 6,
        Mage = 7,
        Assassin = 8,
    }

    public static class QiConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class ShamanConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class KnightConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class WarriorConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class PriestConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class WarlockConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class MageConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }
    public static class AssassinConstants
    {
        public static HeroPart Head = new HeroPart(1, 1, 1);
        public static HeroPart Face = new HeroPart(1, 1, 1);
        public static HeroPart Body = new HeroPart(1, 1, 1);
        public static HeroPart Eyes = new HeroPart(1, 1, 1);
        public static HeroPart Ears = new HeroPart(1, 1, 1);
        public static HeroPart Legs = new HeroPart(1, 1, 1);
    }











    public class HeroPart
    {
        public HeroPart(int hp, int att, int spo)
        {
            HP = hp;
            ATT = att;
            SPO = spo;
        }
        public int HP { get; }
        public int ATT { get; }
        public int SPO { get; }
    }
}

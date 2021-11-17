using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class HeroComposition
    {
        public HeroComposition() { }
        public HeroComposition(Race head, Race face, Race body, Race eyes, Race ears, Race legs)
        {
            Head = head;
            Face = face;
            Body = body;
            Eyes = eyes;
            Ears = ears;
            Legs = legs;
        }
        public Race Head { get; }
        public Race Face { get; }
        public Race Body { get; }
        public Race Eyes { get; }
        public Race Ears { get; }
        public Race Legs { get; }
    }
}

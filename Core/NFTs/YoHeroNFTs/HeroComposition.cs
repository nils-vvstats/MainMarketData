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
            Id = Guid.NewGuid();
            Head = head;
            Face = face;
            Body = body;
            Eyes = eyes;
            Ears = ears;
            Legs = legs;
        }

        public Guid Id { get; }
        public Race Head { get; }
        public Race Face { get; }
        public Race Body { get; }
        public Race Eyes { get; }
        public Race Ears { get; }
        public Race Legs { get; }
    }
}

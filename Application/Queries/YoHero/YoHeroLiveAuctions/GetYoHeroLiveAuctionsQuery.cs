using Core.Auctions;
using Core.Auctions.YoHeroLiveAuctions;
using Core.NFTs.YoHeroNFTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.LiveAuctions
{
    public class GetYoHeroLiveAuctionsQuery : IQuery<List<YoHeroLiveAuction>>
    {
        public GetYoHeroLiveAuctionsQuery()
        {

        }
        public GetYoHeroLiveAuctionsQuery(bool? enabled, bool? genesisHero, Race? head, Race? face, Race? body, Race? eyes, Race? ears, Race? legs, int? hp, int? att, int? spo, int? dex, int? crit)
        {
            Enabled = enabled;
            GenesisHero = genesisHero;
            Head = head;
            Face = face;
            Body = body;
            Eyes = eyes;
            Ears = ears;
            Legs = legs;
            Hp = hp;
            Att = att;
            Spo = spo;
            Dex = dex;
            Crit = crit;
        }
        public bool? Enabled { get; set; }
        public bool? GenesisHero { get; set; }
        public Race? Head { get; set; }
        public Race? Face { get; set;}
        public Race? Body { get; set;}
        public Race? Eyes { get; set;}
        public Race? Ears { get; set;}
        public Race? Legs { get; set;}
        public int? Hp { get; set; }
        public int? Att { get; set; }
        public int? Spo { get; set; }
        public int? Dex { get; set; }
        public int? Crit { get; set; }
    }
}

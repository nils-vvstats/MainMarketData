using Application.Interfaces;
using Core.Auctions.YoHeroLiveAuctions;
using Core.NFTs.YoHeroNFTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.YoHero
{
    public class YoHeroLiveAuctionsFilter : IFilter
    {
        public bool? Enabled { get; set; }
        public bool? GenesisHero { get; set; }
        public Race? Head { get; set; }
        public Race? Face { get; set; }
        public Race? Legs { get; set; }
        public Race? Body { get; set; }
        public Race? Eyes { get; set; }
        public Race? Ears { get; set; }
        public int? Hp { get; set; }
        public int? Att { get; set;}
        public int? Spo { get; set;}
        public int? Dex { get; set; }
        public int? Crit { get; set; }
    }
}

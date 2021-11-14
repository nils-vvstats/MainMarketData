using Core.NFTs.YoHeroNFTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auctions.YoHeroLiveAuctions
{
    public class YoHeroLiveAuction : ILiveAuction
    {
        public YoHeroLiveAuction() { }
        public YoHeroLiveAuction(Hero hero, double auctionPrice)
        {
            Id = Guid.NewGuid();
            Hero = hero;
            AuctionPrice = auctionPrice;
        }

        public Guid Id { get; }
        public Hero Hero { get; }
        public double AuctionPrice { get; }
    }
}

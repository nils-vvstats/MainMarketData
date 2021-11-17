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
        public YoHeroLiveAuction(Hero hero, double auctionPrice, bool enabled)
        {
            YoHeroLiveAuctionId = Guid.NewGuid();
            Hero = hero;
            AuctionPrice = auctionPrice;
            Enabled = enabled;
        }
        public Guid YoHeroLiveAuctionId { get; set; }
        public virtual Hero Hero { get; set; }
        public double AuctionPrice { get; set; }
        public bool Enabled { get; set; }
    }
}

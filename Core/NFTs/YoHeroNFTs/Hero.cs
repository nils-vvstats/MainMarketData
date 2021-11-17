using Core.Auctions.YoHeroLiveAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NFTs.YoHeroNFTs
{
    public class Hero : NFT
    {
        public Hero() { }
        public Hero(int id, HeroProperties heroProperties)
        {
            Id = Guid.NewGuid();
            HeroID = id;
            HeroProperties = heroProperties;
        }
        public Guid Id { get; set; }
        public int HeroID { get; set; }
        public virtual HeroProperties HeroProperties { get; set; }

        public virtual List<YoHeroLiveAuction> YoHeroLiveAuctions { get; set; }

        //public YoHeroLiveAuction YoHeroLiveAuction { get; set; }
        //public int YoHeroLiveAuctionId { get; set; }
    }
}

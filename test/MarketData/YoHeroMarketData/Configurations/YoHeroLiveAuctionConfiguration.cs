using Core.Auctions.YoHeroLiveAuctions;
using Core.NFTs.YoHeroNFTs;
using DataAccess.MarketData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.Configurations
{
    public class YoHeroLiveAuctionConfiguration : IEntityTypeConfiguration<YoHeroLiveAuction>
    {
        public void Configure(EntityTypeBuilder<YoHeroLiveAuction> builder)
        {
            builder.Property(i => i.AuctionPrice);
        }
    }
}

using Core.Auctions.YoHeroLiveAuctions;
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
            builder.HasKey(i => i.Id);
            builder.Property(i => i.AuctionPrice);

            builder.HasOne(la => la.Hero);
                
            //builder.OwnsOne(la => la.Hero);
        }
    }
}

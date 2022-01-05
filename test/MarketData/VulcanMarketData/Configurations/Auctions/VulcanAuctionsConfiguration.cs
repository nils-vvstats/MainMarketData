using Core.Auctions.VulcanAuctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.VulcanMarketData.Configurations.Auctions
{
    public class VulcanAuctionsConfiguration : IEntityTypeConfiguration<VulcanAuction>
    {
        public void Configure(EntityTypeBuilder<VulcanAuction> builder)
        {
            builder.HasBaseType<Auction>();
        }
    }
}

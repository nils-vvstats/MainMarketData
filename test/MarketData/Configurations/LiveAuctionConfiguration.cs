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
    public class LiveAuctionConfiguration : IEntityTypeConfiguration<LiveAuction>
    {
        public void Configure(EntityTypeBuilder<LiveAuction> builder)
        {

        }
    }
}

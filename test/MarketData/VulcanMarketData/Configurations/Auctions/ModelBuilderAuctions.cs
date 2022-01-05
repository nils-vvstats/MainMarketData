using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.VulcanMarketData.Configurations.Auctions
{
    public static class ModelBuilderAuctions
    {
        public static void ConfigureAuctions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuctionsConfiguration());
            modelBuilder.ApplyConfiguration(new VulcanAuctionsConfiguration());

        }
    }
}

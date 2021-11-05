using DataAccess.MarketData.Configurations;
using DataAccess.MarketData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MarketDataDbContext : DbContext
    {

        public virtual DbSet<LiveAuction> LiveAuctions { get; set; } 

        public MarketDataDbContext(DbContextOptions<MarketDataDbContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LiveAuctionConfiguration());
        }
    }
}

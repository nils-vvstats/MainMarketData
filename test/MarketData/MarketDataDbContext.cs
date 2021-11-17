using Core.Auctions.YoHeroLiveAuctions;
using Core.NFTs.YoHeroNFTs;
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

        public virtual DbSet<YoHeroLiveAuction> YoHeroLiveAuctions { get; set; } 
        public virtual DbSet<Hero> Heroes { get; set; }
        //public virtual DbSet<HeroProperties> HeroProperties { get; set; }
        //public virtual DbSet<HeroAttributes> HeroAttributes { get; set; }
        //public virtual DbSet<HeroComposition> HeroCompositions { get; set; }

        public MarketDataDbContext(DbContextOptions<MarketDataDbContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new YoHeroLiveAuctionConfiguration());
            modelBuilder.ApplyConfiguration(new HeroConfiguration());
            //modelBuilder.ApplyConfiguration(new HeroPropertiesConfiguration());
            //modelBuilder.ApplyConfiguration(new HeroAttributesConfiguration());
            //modelBuilder.ApplyConfiguration(new HeroCompositionConfiguration());
        }
    }
}

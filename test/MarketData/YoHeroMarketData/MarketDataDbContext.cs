using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MarketDataDbContext : DbContext
    {

        //public virtual DbSet<YoHeroLiveAuction> YoHeroLiveAuctions { get; set; } 
        //public virtual DbSet<Hero> Heroes { get; set; }
        //public virtual DbSet<YoHeroUser> YoHeroUsers { get; set; }
        ////public virtual DbSet<YoHeroAlert> YoHeroAlerts { get; set; }
        //public virtual DbSet<BSCPayment> YoHeroPayments { get; set; }

        public MarketDataDbContext(DbContextOptions<MarketDataDbContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new YoHeroLiveAuctionConfiguration());
            //modelBuilder.ApplyConfiguration(new HeroConfiguration());
            //modelBuilder.ApplyConfiguration(new YoHeroUserConfiguration());
            ////modelBuilder.ApplyConfiguration(new YoHeroAlertConfiguration());
            //modelBuilder.ApplyConfiguration(new YoHeroPaymentConfiguration());

        }
    }
}

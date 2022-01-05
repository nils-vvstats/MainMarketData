using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using Core.Auctions.VulcanAuctions;
using DataAccess.MarketData.VulcanMarketData.Configurations;
using DataAccess.MarketData.VulcanMarketData.Configurations.Alerts;
using DataAccess.MarketData.VulcanMarketData.Configurations.Auctions;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class VulcanMarketDataDbContext : DbContext
    {
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<VulcanAlert> VulcanAlerts { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<VulcanAuction> VulcanAuctions { get; set; }

        public VulcanMarketDataDbContext(DbContextOptions<VulcanMarketDataDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureAlerts();
            modelBuilder.ConfigureAuctions();
        }
    }
}

using Core.Payments.BSCPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.YoHeroMarketData.Configurations
{
    public class YoHeroPaymentConfiguration : IEntityTypeConfiguration<BSCPayment>
    {
        public void Configure(EntityTypeBuilder<BSCPayment> builder)
        {
            builder.HasKey(p => p.TransactionId);
            builder.Property(p => p.UserId);
            builder.Property(p => p.From);
            builder.Property(p => p.To);
            builder.Property(p => p.Amount);

            builder.HasOne(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(u => u.ID);
        }
    }
}

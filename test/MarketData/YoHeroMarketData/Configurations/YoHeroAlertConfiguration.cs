
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DataAccess.MarketData.Configurations
//{
//    public class YoHeroAlertConfiguration : IEntityTypeConfiguration<YoHeroAlert>
//    {
//        public void Configure(EntityTypeBuilder<YoHeroAlert> builder)
//        {
//            builder.HasKey(a => a.ID);
//            builder.Property(a => a.UserId);

//            builder.Property(a => a.Test);
//            builder.HasOne(a => a.User)
//                .WithMany(u => u.Alerts)
//                .HasForeignKey(u => u.UserId);
//        }
//    }
//}

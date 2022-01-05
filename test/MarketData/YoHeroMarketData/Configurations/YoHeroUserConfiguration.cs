//using Core.Alerts.YoHeroAlerts;
//using Core.Users;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.MarketData.Configurations
//{
//    public class YoHeroUserConfiguration : IEntityTypeConfiguration<YoHeroUser>
//    {
//        public void Configure(EntityTypeBuilder<YoHeroUser> builder)
//        {
//            builder.HasKey(u => u.ID);
//            builder.Property(u => u.ChatId);

//            builder.HasMany(u => u.Alerts)
//                .WithOne(a => a.User)
//                .HasForeignKey(a => a.UserId);


//            builder.HasMany(u => u.Payments)
//                .WithOne(p => p.User)
//                .HasForeignKey(p => p.UserId);

//        }
//    } 
//}

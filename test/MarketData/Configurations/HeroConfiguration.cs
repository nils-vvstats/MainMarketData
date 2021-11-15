using Core.NFTs.YoHeroNFTs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.Configurations
{
    public class HeroConfiguration : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.HeroID);
            //builder.Property(i => i.HeroProperties);

            builder.HasOne(h => h.HeroProperties);
        }
    }
}

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

    public class HeroPropertiesConfiguration : IEntityTypeConfiguration<HeroProperties>
    {
        public void Configure(EntityTypeBuilder<HeroProperties> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.GenesisHero);
            builder.Property(i => i.NumberOfSummons);
            builder.Property(i => i.Race);

            builder.HasOne(hp => hp.HeroAttributes);
            builder.HasOne(hp => hp.HeroComposition);

            //builder.Property(i => i.HeroAttributes);
            //builder.Property(i => i.HeroComposition);
        }
    }
}

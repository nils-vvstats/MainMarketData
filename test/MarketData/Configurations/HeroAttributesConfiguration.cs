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
    public class HeroAttributesConfiguration : IEntityTypeConfiguration<HeroAttributes>
    {
        public void Configure(EntityTypeBuilder<HeroAttributes> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.HP);
            builder.Property(i => i.ATT);
            builder.Property(i => i.SPO);
            builder.Property(i => i.CRIT);
            builder.Property(i => i.DEX);
        }
    }
}

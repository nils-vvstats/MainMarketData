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
    public class HeroCompositionConfiguration : IEntityTypeConfiguration<HeroComposition>
    {
        public void Configure(EntityTypeBuilder<HeroComposition> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Head);
            builder.Property(i => i.Face);
            builder.Property(i => i.Body);
            builder.Property(i => i.Eyes);
            builder.Property(i => i.Ears);
            builder.Property(i => i.Legs);
        }
    }
}

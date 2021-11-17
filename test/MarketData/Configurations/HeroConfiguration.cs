using Core.Auctions.YoHeroLiveAuctions;
using Core.NFTs.YoHeroNFTs;
using DataAccess.MarketData.Models;
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
            builder.OwnsOne(i => i.HeroProperties);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition);


            builder.OwnsOne(i => i.HeroProperties).Property(hp => hp.GenesisHero);
            builder.OwnsOne(i => i.HeroProperties).Property(hp => hp.NumberOfSummons);
            builder.OwnsOne(i => i.HeroProperties).Property(hp => hp.Race);

            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.ATT);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.CRIT);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.DEX);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.HP);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.SPO);



            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Head);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Face);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Body);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Legs);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Eyes);
            builder.OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Ears);

        }
    }
}

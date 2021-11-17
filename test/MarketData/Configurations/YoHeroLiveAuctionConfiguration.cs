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
    public class YoHeroLiveAuctionConfiguration : IEntityTypeConfiguration<YoHeroLiveAuction>
    {
        public void Configure(EntityTypeBuilder<YoHeroLiveAuction> builder)
        {
            //builder.Property(i => i.AuctionPrice);
            builder.Property(i => i.AuctionPrice);

            //builder.HasOne(la => la.Hero)
            //    .WithMany(h => h.YoHeroLiveAuctions)
            //    .HasForeignKey<YoHeroLiveAuction>(h => h.YoHeroLiveAuctions);
            //builder.HasKey( i=> i. )
            //builder.HasBaseType<YoHeroLiveAuction>();

            //builder.HasKey(i => i.HeroId); 
            //builder.Property(i => i.AuctionPrice);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).Property(hp => hp.GenesisHero);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).Property(hp => hp.NumberOfSummons);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).Property(hp => hp.Race);

            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.ATT);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.CRIT);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.DEX);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.HP);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroAttributes).Property(ha => ha.SPO);



            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Head);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Face);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Body);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Legs);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Eyes);
            //builder.OwnsOne(i => i.Hero).OwnsOne(i => i.HeroProperties).OwnsOne(i => i.HeroComposition).Property(hc => hc.Ears);
            //builder.Property(i => i.HeroId);

            ////builder.HasOne(la => la.Hero);

            //builder.HasOne(la => la.Hero)
            //    .WithOne(h => h.YoHeroLiveAuction)
            //    .HasForeignKey<Hero>(h => h.YoHeroLiveAuctionId);

            /*
             * has one other object
             * with one current object
             * foreign key other object
             */
        }
    }
}

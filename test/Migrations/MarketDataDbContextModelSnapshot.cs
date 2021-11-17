﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(MarketDataDbContext))]
    partial class MarketDataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Auctions.YoHeroLiveAuctions.YoHeroLiveAuction", b =>
                {
                    b.Property<Guid>("YoHeroLiveAuctionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AuctionPrice")
                        .HasColumnType("float");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<Guid?>("HeroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("YoHeroLiveAuctionId");

                    b.HasIndex("HeroId");

                    b.ToTable("YoHeroLiveAuctions");
                });

            modelBuilder.Entity("Core.NFTs.YoHeroNFTs.Hero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HeroID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("Core.Auctions.YoHeroLiveAuctions.YoHeroLiveAuction", b =>
                {
                    b.HasOne("Core.NFTs.YoHeroNFTs.Hero", "Hero")
                        .WithMany("YoHeroLiveAuctions")
                        .HasForeignKey("HeroId");

                    b.Navigation("Hero");
                });

            modelBuilder.Entity("Core.NFTs.YoHeroNFTs.Hero", b =>
                {
                    b.OwnsOne("Core.NFTs.YoHeroNFTs.HeroProperties", "HeroProperties", b1 =>
                        {
                            b1.Property<Guid>("HeroId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("GenesisHero")
                                .HasColumnType("bit");

                            b1.Property<int>("NumberOfSummons")
                                .HasColumnType("int");

                            b1.Property<int>("Race")
                                .HasColumnType("int");

                            b1.HasKey("HeroId");

                            b1.ToTable("Heroes");

                            b1.WithOwner()
                                .HasForeignKey("HeroId");

                            b1.OwnsOne("Core.NFTs.YoHeroNFTs.HeroAttributes", "HeroAttributes", b2 =>
                                {
                                    b2.Property<Guid>("HeroPropertiesHeroId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("ATT")
                                        .HasColumnType("int");

                                    b2.Property<int>("CRIT")
                                        .HasColumnType("int");

                                    b2.Property<int>("DEX")
                                        .HasColumnType("int");

                                    b2.Property<int>("HP")
                                        .HasColumnType("int");

                                    b2.Property<int>("SPO")
                                        .HasColumnType("int");

                                    b2.HasKey("HeroPropertiesHeroId");

                                    b2.ToTable("Heroes");

                                    b2.WithOwner()
                                        .HasForeignKey("HeroPropertiesHeroId");
                                });

                            b1.OwnsOne("Core.NFTs.YoHeroNFTs.HeroComposition", "HeroComposition", b2 =>
                                {
                                    b2.Property<Guid>("HeroPropertiesHeroId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Body")
                                        .HasColumnType("int");

                                    b2.Property<int>("Ears")
                                        .HasColumnType("int");

                                    b2.Property<int>("Eyes")
                                        .HasColumnType("int");

                                    b2.Property<int>("Face")
                                        .HasColumnType("int");

                                    b2.Property<int>("Head")
                                        .HasColumnType("int");

                                    b2.Property<int>("Legs")
                                        .HasColumnType("int");

                                    b2.HasKey("HeroPropertiesHeroId");

                                    b2.ToTable("Heroes");

                                    b2.WithOwner()
                                        .HasForeignKey("HeroPropertiesHeroId");
                                });

                            b1.Navigation("HeroAttributes");

                            b1.Navigation("HeroComposition");
                        });

                    b.Navigation("HeroProperties");
                });

            modelBuilder.Entity("Core.NFTs.YoHeroNFTs.Hero", b =>
                {
                    b.Navigation("YoHeroLiveAuctions");
                });
#pragma warning restore 612, 618
        }
    }
}

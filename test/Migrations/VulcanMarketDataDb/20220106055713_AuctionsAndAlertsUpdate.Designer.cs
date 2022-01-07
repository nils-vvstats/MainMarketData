﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations.VulcanMarketDataDb
{
    [DbContext(typeof(VulcanMarketDataDbContext))]
    [Migration("20220106055713_AuctionsAndAlertsUpdate")]
    partial class AuctionsAndAlertsUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Alerts.Alert", b =>
                {
                    b.Property<Guid>("AlertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("SendAlert")
                        .HasColumnType("bit");

                    b.Property<string>("StringExpression")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("AlertId");

                    b.ToTable("Alerts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Alert");
                });

            modelBuilder.Entity("Core.Auctions.VulcanAuctions.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuctionDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SendAlert")
                        .HasColumnType("bit");

                    b.HasKey("AuctionId");

                    b.ToTable("Auctions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Auction");
                });

            modelBuilder.Entity("Core.Alerts.VulcanAlerts.VulcanAlert", b =>
                {
                    b.HasBaseType("Core.Alerts.Alert");

                    b.HasDiscriminator().HasValue("VulcanAlert");
                });

            modelBuilder.Entity("Core.Auctions.VulcanAuctions.VulcanAuction", b =>
                {
                    b.HasBaseType("Core.Auctions.VulcanAuctions.Auction");

                    b.HasDiscriminator().HasValue("VulcanAuction");
                });
#pragma warning restore 612, 618
        }
    }
}
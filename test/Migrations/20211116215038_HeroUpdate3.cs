using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class HeroUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeroID = table.Column<int>(type: "int", nullable: false),
                    HeroProperties_Race = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_NumberOfSummons = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroAttributes_HP = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroAttributes_ATT = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroAttributes_SPO = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroAttributes_DEX = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroAttributes_CRIT = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroComposition_Head = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroComposition_Face = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroComposition_Body = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroComposition_Eyes = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroComposition_Ears = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_HeroComposition_Legs = table.Column<int>(type: "int", nullable: true),
                    HeroProperties_GenesisHero = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YoHeroLiveAuctions",
                columns: table => new
                {
                    YoHeroLiveAuctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeroId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuctionPrice = table.Column<double>(type: "float", nullable: false),
                    enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoHeroLiveAuctions", x => x.YoHeroLiveAuctionId);
                    table.ForeignKey(
                        name: "FK_YoHeroLiveAuctions_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YoHeroLiveAuctions_HeroId",
                table: "YoHeroLiveAuctions",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YoHeroLiveAuctions");

            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}

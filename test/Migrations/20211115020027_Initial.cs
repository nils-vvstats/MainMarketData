using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    ATT = table.Column<int>(type: "int", nullable: false),
                    SPO = table.Column<int>(type: "int", nullable: false),
                    DEX = table.Column<int>(type: "int", nullable: false),
                    CRIT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroCompositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Head = table.Column<int>(type: "int", nullable: false),
                    Face = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<int>(type: "int", nullable: false),
                    Eyes = table.Column<int>(type: "int", nullable: false),
                    Ears = table.Column<int>(type: "int", nullable: false),
                    Legs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroCompositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Race = table.Column<int>(type: "int", nullable: false),
                    NumberOfSummons = table.Column<int>(type: "int", nullable: false),
                    HeroAttributesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HeroCompositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenesisHero = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroProperties_HeroAttributes_HeroAttributesId",
                        column: x => x.HeroAttributesId,
                        principalTable: "HeroAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeroProperties_HeroCompositions_HeroCompositionId",
                        column: x => x.HeroCompositionId,
                        principalTable: "HeroCompositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeroID = table.Column<int>(type: "int", nullable: false),
                    HeroPropertiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_HeroProperties_HeroPropertiesId",
                        column: x => x.HeroPropertiesId,
                        principalTable: "HeroProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YoHeroLiveAuctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeroId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuctionPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoHeroLiveAuctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YoHeroLiveAuctions_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_HeroPropertiesId",
                table: "Heroes",
                column: "HeroPropertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroProperties_HeroAttributesId",
                table: "HeroProperties",
                column: "HeroAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroProperties_HeroCompositionId",
                table: "HeroProperties",
                column: "HeroCompositionId");

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

            migrationBuilder.DropTable(
                name: "HeroProperties");

            migrationBuilder.DropTable(
                name: "HeroAttributes");

            migrationBuilder.DropTable(
                name: "HeroCompositions");
        }
    }
}

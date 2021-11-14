using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UpdateHeroConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AuctionPrice",
                table: "YoHeroLiveAuctions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "HeroID",
                table: "YoHeroLiveAuctions",
                type: "int",
                nullable: true);

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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroPropertiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Heroes_HeroProperties_HeroPropertiesId",
                        column: x => x.HeroPropertiesId,
                        principalTable: "HeroProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YoHeroLiveAuctions_HeroID",
                table: "YoHeroLiveAuctions",
                column: "HeroID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_YoHeroLiveAuctions_Heroes_HeroID",
                table: "YoHeroLiveAuctions",
                column: "HeroID",
                principalTable: "Heroes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YoHeroLiveAuctions_Heroes_HeroID",
                table: "YoHeroLiveAuctions");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "HeroProperties");

            migrationBuilder.DropTable(
                name: "HeroAttributes");

            migrationBuilder.DropTable(
                name: "HeroCompositions");

            migrationBuilder.DropIndex(
                name: "IX_YoHeroLiveAuctions_HeroID",
                table: "YoHeroLiveAuctions");

            migrationBuilder.DropColumn(
                name: "AuctionPrice",
                table: "YoHeroLiveAuctions");

            migrationBuilder.DropColumn(
                name: "HeroID",
                table: "YoHeroLiveAuctions");
        }
    }
}

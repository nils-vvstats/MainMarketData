using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class HeroUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuctionPrice",
                table: "YoHeroLiveAuctions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AuctionPrice",
                table: "YoHeroLiveAuctions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

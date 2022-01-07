using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.VulcanMarketDataDb
{
    public partial class AuctionsAndAlertsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SendAlert",
                table: "Auctions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SendAlert",
                table: "Alerts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendAlert",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "SendAlert",
                table: "Alerts");
        }
    }
}

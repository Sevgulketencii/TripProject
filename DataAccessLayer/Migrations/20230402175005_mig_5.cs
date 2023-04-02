using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverPhoto",
                table: "DestinationDbSet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail1",
                table: "DestinationDbSet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail2",
                table: "DestinationDbSet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouteImage2",
                table: "DestinationDbSet",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverPhoto",
                table: "DestinationDbSet");

            migrationBuilder.DropColumn(
                name: "Detail1",
                table: "DestinationDbSet");

            migrationBuilder.DropColumn(
                name: "Detail2",
                table: "DestinationDbSet");

            migrationBuilder.DropColumn(
                name: "RouteImage2",
                table: "DestinationDbSet");
        }
    }
}

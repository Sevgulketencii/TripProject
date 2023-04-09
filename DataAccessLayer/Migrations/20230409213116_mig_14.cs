using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "ReservationDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDbSet_DestinationID",
                table: "ReservationDbSet",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationDbSet_DestinationDbSet_DestinationID",
                table: "ReservationDbSet",
                column: "DestinationID",
                principalTable: "DestinationDbSet",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationDbSet_DestinationDbSet_DestinationID",
                table: "ReservationDbSet");

            migrationBuilder.DropIndex(
                name: "IX_ReservationDbSet_DestinationID",
                table: "ReservationDbSet");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "ReservationDbSet");
        }
    }
}

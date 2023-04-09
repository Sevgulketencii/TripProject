using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_AppUserID",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "ReservationDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_AppUserID",
                table: "ReservationDbSet",
                newName: "IX_ReservationDbSet_AppUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationDbSet",
                table: "ReservationDbSet",
                column: "ReservationID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationDbSet_AspNetUsers_AppUserID",
                table: "ReservationDbSet",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationDbSet_AspNetUsers_AppUserID",
                table: "ReservationDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationDbSet",
                table: "ReservationDbSet");

            migrationBuilder.RenameTable(
                name: "ReservationDbSet",
                newName: "Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationDbSet_AppUserID",
                table: "Reservation",
                newName: "IX_Reservation_AppUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "ReservationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_AppUserID",
                table: "Reservation",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

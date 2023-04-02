using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentDbSet_DestinationDbSet_DestinationID",
                table: "CommentDbSet");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationID",
                table: "CommentDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentDbSet_DestinationDbSet_DestinationID",
                table: "CommentDbSet",
                column: "DestinationID",
                principalTable: "DestinationDbSet",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentDbSet_DestinationDbSet_DestinationID",
                table: "CommentDbSet");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationID",
                table: "CommentDbSet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentDbSet_DestinationDbSet_DestinationID",
                table: "CommentDbSet",
                column: "DestinationID",
                principalTable: "DestinationDbSet",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_DestinationDbSet_DestinationID",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "CommentDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_DestinationID",
                table: "CommentDbSet",
                newName: "IX_CommentDbSet_DestinationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentDbSet",
                table: "CommentDbSet",
                column: "CommnetID");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentDbSet_DestinationDbSet_DestinationID",
                table: "CommentDbSet",
                column: "DestinationID",
                principalTable: "DestinationDbSet",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentDbSet_DestinationDbSet_DestinationID",
                table: "CommentDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentDbSet",
                table: "CommentDbSet");

            migrationBuilder.RenameTable(
                name: "CommentDbSet",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_CommentDbSet_DestinationID",
                table: "Comment",
                newName: "IX_Comment_DestinationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "CommnetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_DestinationDbSet_DestinationID",
                table: "Comment",
                column: "DestinationID",
                principalTable: "DestinationDbSet",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

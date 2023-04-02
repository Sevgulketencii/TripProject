using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature2DbSet",
                table: "Feature2DbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutDbSet",
                table: "AboutDbSet");

            migrationBuilder.RenameTable(
                name: "Feature2DbSet",
                newName: "Feature2");

            migrationBuilder.RenameTable(
                name: "AboutDbSet",
                newName: "About");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature2",
                table: "Feature2",
                column: "Feature2Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_About",
                table: "About",
                column: "AboutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature2",
                table: "Feature2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_About",
                table: "About");

            migrationBuilder.RenameTable(
                name: "Feature2",
                newName: "Feature2DbSet");

            migrationBuilder.RenameTable(
                name: "About",
                newName: "AboutDbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature2DbSet",
                table: "Feature2DbSet",
                column: "Feature2Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutDbSet",
                table: "AboutDbSet",
                column: "AboutID");
        }
    }
}

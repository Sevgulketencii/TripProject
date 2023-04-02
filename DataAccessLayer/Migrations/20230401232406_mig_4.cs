using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "About2DbSet",
                columns: table => new
                {
                    About2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About2Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About2DbSet", x => x.About2ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactDbSet",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDbSet", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "GuideDbSet",
                columns: table => new
                {
                    GuideID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuideName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideInstagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuideDbSet", x => x.GuideID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About2DbSet");

            migrationBuilder.DropTable(
                name: "ContactDbSet");

            migrationBuilder.DropTable(
                name: "GuideDbSet");

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
    }
}










using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutDbSet",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDesciription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDesciription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutDbSet", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "DestinationDbSet",
                columns: table => new
                {
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationDbSet", x => x.DestinationID);
                });

            migrationBuilder.CreateTable(
                name: "Feature2DbSet",
                columns: table => new
                {
                    Feature2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature2DbSet", x => x.Feature2Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureDbSet",
                columns: table => new
                {
                    Feature1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post1Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post1Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post1Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureDbSet", x => x.Feature1Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsletterDbSet",
                columns: table => new
                {
                    NewsletterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsletterMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsletterDbSet", x => x.NewsletterID);
                });

            migrationBuilder.CreateTable(
                name: "SubAboutDbSet",
                columns: table => new
                {
                    SubAboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubAboutDesciription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAboutDbSet", x => x.SubAboutID);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialDbSet",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialDbSet", x => x.TestimonialID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutDbSet");

            migrationBuilder.DropTable(
                name: "DestinationDbSet");

            migrationBuilder.DropTable(
                name: "Feature2DbSet");

            migrationBuilder.DropTable(
                name: "FeatureDbSet");

            migrationBuilder.DropTable(
                name: "NewsletterDbSet");

            migrationBuilder.DropTable(
                name: "SubAboutDbSet");

            migrationBuilder.DropTable(
                name: "TestimonialDbSet");
        }
    }
}

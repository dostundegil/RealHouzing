using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLayer.Migrations
{
    public partial class addedentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<int>(type: "int", nullable: false),
                    AgentTitle = table.Column<int>(type: "int", nullable: false),
                    AgentPhone = table.Column<int>(type: "int", nullable: false),
                    AgentMail = table.Column<int>(type: "int", nullable: false),
                    AgentImage = table.Column<int>(type: "int", nullable: false),
                    AgentSocial1 = table.Column<int>(type: "int", nullable: false),
                    AgentSocial2 = table.Column<int>(type: "int", nullable: false),
                    AgentSocial3 = table.Column<int>(type: "int", nullable: false),
                    AgentSocial4 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentID);
                });

            migrationBuilder.CreateTable(
                name: "Featuess",
                columns: table => new
                {
                    FeatuesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatuesTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatuesContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatuesImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Featuess", x => x.FeatuesID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Featuess");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}

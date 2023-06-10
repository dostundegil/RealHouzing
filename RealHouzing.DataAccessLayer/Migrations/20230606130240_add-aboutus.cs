using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLayer.Migrations
{
    public partial class addaboutus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUss",
                columns: table => new
                {
                    AboutUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutUsContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUss", x => x.AboutUsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUss");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLayer.Migrations
{
    public partial class addedmanytomany3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPropertyFeaturess",
                columns: table => new
                {
                    ProductPropertyFeaturesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    PropertyFeaturesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPropertyFeaturess", x => x.ProductPropertyFeaturesID);
                    table.ForeignKey(
                        name: "FK_ProductPropertyFeaturess_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPropertyFeaturess_PropertyFeatures_PropertyFeaturesID",
                        column: x => x.PropertyFeaturesID,
                        principalTable: "PropertyFeatures",
                        principalColumn: "PropertyFeaturesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropertyFeaturess_ProductID",
                table: "ProductPropertyFeaturess",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropertyFeaturess_PropertyFeaturesID",
                table: "ProductPropertyFeaturess",
                column: "PropertyFeaturesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPropertyFeaturess");
        }
    }
}

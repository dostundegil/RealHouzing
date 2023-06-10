using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLayer.Migrations
{
    public partial class addedmanytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyFeatures_Products_ProductID",
                table: "PropertyFeatures");

            migrationBuilder.DropIndex(
                name: "IX_PropertyFeatures_ProductID",
                table: "PropertyFeatures");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "PropertyFeatures");

            migrationBuilder.CreateTable(
                name: "ProductPropertyFeatures",
                columns: table => new
                {
                    ProductsProductID = table.Column<int>(type: "int", nullable: false),
                    PropertyFeaturessPropertyFeaturesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPropertyFeatures", x => new { x.ProductsProductID, x.PropertyFeaturessPropertyFeaturesID });
                    table.ForeignKey(
                        name: "FK_ProductPropertyFeatures_Products_ProductsProductID",
                        column: x => x.ProductsProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPropertyFeatures_PropertyFeatures_PropertyFeaturessPropertyFeaturesID",
                        column: x => x.PropertyFeaturessPropertyFeaturesID,
                        principalTable: "PropertyFeatures",
                        principalColumn: "PropertyFeaturesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropertyFeatures_PropertyFeaturessPropertyFeaturesID",
                table: "ProductPropertyFeatures",
                column: "PropertyFeaturessPropertyFeaturesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPropertyFeatures");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "PropertyFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyFeatures_ProductID",
                table: "PropertyFeatures",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyFeatures_Products_ProductID",
                table: "PropertyFeatures",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

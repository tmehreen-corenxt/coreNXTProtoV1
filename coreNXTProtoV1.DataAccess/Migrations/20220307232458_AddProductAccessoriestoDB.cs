using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreNXTProtoV1.DataAccess.Migrations
{
    public partial class AddProductAccessoriestoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductAccessories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AccessoryProductId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    IsPreferred = table.Column<byte>(type: "tinyint", nullable: false),
                    IsOption = table.Column<byte>(type: "tinyint", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recommendation_Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ProductAccessories_Product_AccessoryProductId",
                        column: x => x.AccessoryProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_ProductAccessories_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAccessories_AccessoryProductId",
                table: "ProductAccessories",
                column: "AccessoryProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAccessories_ProductId",
                table: "ProductAccessories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAccessories");
        }
    }
}

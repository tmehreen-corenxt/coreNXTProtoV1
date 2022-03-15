using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreNXTProtoV1.DataAccess.Migrations
{
    public partial class AddCategoryHeadertoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryHeader",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    TemplateType = table.Column<int>(type: "int", nullable: false),
                    DefaultDisplayOrder = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeaderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CategoryHeader_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryHeader_HeaderNames_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "HeaderNames",
                        principalColumn: "HeaderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryHeader_CategoryId",
                table: "CategoryHeader",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryHeader_HeaderId",
                table: "CategoryHeader",
                column: "HeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryHeader");
        }
    }
}

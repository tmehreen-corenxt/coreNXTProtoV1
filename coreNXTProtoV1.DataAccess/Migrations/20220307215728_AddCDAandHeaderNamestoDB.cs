using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreNXTProtoV1.DataAccess.Migrations
{
    public partial class AddCDAandHeaderNamestoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeaderNames",
                columns: table => new
                {
                    HeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    LocaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderNames", x => x.HeaderId);
                    table.ForeignKey(
                        name: "FK_HeaderNames_Locales_LocaleId",
                        column: x => x.LocaleId,
                        principalTable: "Locales",
                        principalColumn: "LocaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDisplayAttributes",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_CategoryDisplayAttributes_AttributeNames_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "AttributeNames",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDisplayAttributes_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDisplayAttributes_HeaderNames_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "HeaderNames",
                        principalColumn: "HeaderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDisplayAttributes_AttributeId",
                table: "CategoryDisplayAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDisplayAttributes_CategoryId",
                table: "CategoryDisplayAttributes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDisplayAttributes_HeaderId",
                table: "CategoryDisplayAttributes",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderNames_LocaleId",
                table: "HeaderNames",
                column: "LocaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDisplayAttributes");

            migrationBuilder.DropTable(
                name: "HeaderNames");
        }
    }
}

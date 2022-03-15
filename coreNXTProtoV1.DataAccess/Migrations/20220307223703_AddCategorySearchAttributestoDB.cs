using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreNXTProtoV1.DataAccess.Migrations
{
    public partial class AddCategorySearchAttributestoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorySearchAttributes",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    IsPreferred = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySearchAttributes", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_CategorySearchAttributes_AttributeNames_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "AttributeNames",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySearchAttributes_AttributeId",
                table: "CategorySearchAttributes",
                column: "AttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorySearchAttributes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreNXTProtoV1.DataAccess.Migrations
{
    public partial class AddAttributeNmaestoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttributeNames",
                columns: table => new
                {
                    AttributeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    LocaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeNames", x => x.AttributeId);
                    table.ForeignKey(
                        name: "FK_AttributeNames_Locales_LocaleId",
                        column: x => x.LocaleId,
                        principalTable: "Locales",
                        principalColumn: "LocaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeNames_LocaleId",
                table: "AttributeNames",
                column: "LocaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeNames");
        }
    }
}

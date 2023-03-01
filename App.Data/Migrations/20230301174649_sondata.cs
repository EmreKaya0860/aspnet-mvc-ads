using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class sondata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryAdverts");

            migrationBuilder.CreateTable(
                name: "AdvertCategory",
                columns: table => new
                {
                    AdvertsId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertCategory", x => new { x.AdvertsId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_AdvertCategory_Adverts_AdvertsId",
                        column: x => x.AdvertsId,
                        principalTable: "Adverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertCategory_CategoryId",
                table: "AdvertCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertCategory");

            migrationBuilder.CreateTable(
                name: "CategoryAdverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAdverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryAdverts_Adverts_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "Adverts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAdverts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CategoryAdverts",
                columns: new[] { "Id", "AdvertId", "CategoryId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_AdvertId",
                table: "CategoryAdverts",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_CategoryId",
                table: "CategoryAdverts",
                column: "CategoryId");
        }
    }
}

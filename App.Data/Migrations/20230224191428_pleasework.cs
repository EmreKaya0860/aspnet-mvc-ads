using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class pleasework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AdvertComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_UserId",
                table: "AdvertComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_UserId",
                table: "AdvertComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AdvertComments");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Context",
                table: "Pages",
                newName: "Content");

            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "AdvertComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_userID",
                table: "AdvertComments",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Users_userID",
                table: "AdvertComments",
                column: "userID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Users_userID",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_userID",
                table: "AdvertComments");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "AdvertComments");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Pages",
                newName: "Context");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class lastcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Users_UserId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Categories_CategoryId",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId",
                table: "Settings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Settings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryAdverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "CategoryAdverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Adverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "AdvertComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Users_UserId",
                table: "Adverts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Categories_CategoryId",
                table: "CategoryAdverts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId",
                table: "Settings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Users_UserId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Categories_CategoryId",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId",
                table: "Settings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Settings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryAdverts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "CategoryAdverts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Adverts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "AdvertComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Users_UserId",
                table: "Adverts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Categories_CategoryId",
                table: "CategoryAdverts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId",
                table: "Settings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

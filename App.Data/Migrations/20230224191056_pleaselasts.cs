using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class pleaselasts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertUserId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Users_UserId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertUserId1",
                table: "AdvertImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Users_UserId1",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertUserId1",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Categories_CategoryId2",
                table: "CategoryAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId1",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                table: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Settings_UserId1",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryAdverts",
                table: "CategoryAdverts");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAdverts_AdvertUserId1",
                table: "CategoryAdverts");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAdverts_CategoryId2",
                table: "CategoryAdverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_UserId1",
                table: "Adverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertImages",
                table: "AdvertImages");

            migrationBuilder.DropIndex(
                name: "IX_AdvertImages_AdvertUserId1",
                table: "AdvertImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_AdvertUserId",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_UserId",
                table: "AdvertComments");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "AdvertUserId1",
                table: "CategoryAdverts");

            migrationBuilder.DropColumn(
                name: "CategoryId2",
                table: "CategoryAdverts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "AdvertUserId1",
                table: "AdvertImages");

            migrationBuilder.DropColumn(
                name: "AdvertUserId",
                table: "AdvertComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AdvertComments");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Settings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Settings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CategoryAdverts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryAdverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Adverts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Adverts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AdvertImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AdvertComments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                table: "Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryAdverts",
                table: "CategoryAdverts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertImages",
                table: "AdvertImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_UserId",
                table: "Settings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_CategoryId",
                table: "CategoryAdverts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UserId",
                table: "Adverts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertImages_AdvertId",
                table: "AdvertImages",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_AdvertId",
                table: "AdvertComments",
                column: "AdvertId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertId",
                table: "AdvertImages");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                table: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Settings_UserId",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryAdverts",
                table: "CategoryAdverts");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAdverts_CategoryId",
                table: "CategoryAdverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_UserId",
                table: "Adverts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertImages",
                table: "AdvertImages");

            migrationBuilder.DropIndex(
                name: "IX_AdvertImages_AdvertId",
                table: "AdvertImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_AdvertId",
                table: "AdvertComments");

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
                name: "Id",
                table: "Settings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Settings",
                type: "int",
                nullable: true);

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
                name: "Id",
                table: "CategoryAdverts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdvertUserId1",
                table: "CategoryAdverts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId2",
                table: "CategoryAdverts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "Id",
                table: "Adverts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Adverts",
                type: "int",
                nullable: true);

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
                name: "Id",
                table: "AdvertImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdvertUserId1",
                table: "AdvertImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "AdvertComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AdvertComments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdvertUserId",
                table: "AdvertComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AdvertComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                table: "Settings",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryAdverts",
                table: "CategoryAdverts",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertImages",
                table: "AdvertImages",
                column: "AdvertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_UserId1",
                table: "Settings",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_AdvertUserId1",
                table: "CategoryAdverts",
                column: "AdvertUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAdverts_CategoryId2",
                table: "CategoryAdverts",
                column: "CategoryId2");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UserId1",
                table: "Adverts",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertImages_AdvertUserId1",
                table: "AdvertImages",
                column: "AdvertUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_AdvertUserId",
                table: "AdvertComments",
                column: "AdvertUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_UserId",
                table: "AdvertComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId",
                table: "AdvertComments",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertUserId",
                table: "AdvertComments",
                column: "AdvertUserId",
                principalTable: "Adverts",
                principalColumn: "UserId");

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
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertImages_Adverts_AdvertUserId1",
                table: "AdvertImages",
                column: "AdvertUserId1",
                principalTable: "Adverts",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Users_UserId1",
                table: "Adverts",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertId",
                table: "CategoryAdverts",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Adverts_AdvertUserId1",
                table: "CategoryAdverts",
                column: "AdvertUserId1",
                principalTable: "Adverts",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAdverts_Categories_CategoryId2",
                table: "CategoryAdverts",
                column: "CategoryId2",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId1",
                table: "Settings",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}

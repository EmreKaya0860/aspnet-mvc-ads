using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class IthinkLast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_AdvertId",
                table: "AdvertComments");

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
                name: "AdvertId1",
                table: "AdvertComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_AdvertId1",
                table: "AdvertComments",
                column: "AdvertId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId1",
                table: "AdvertComments",
                column: "AdvertId1",
                principalTable: "Adverts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertComments_Adverts_AdvertId1",
                table: "AdvertComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertComments",
                table: "AdvertComments");

            migrationBuilder.DropIndex(
                name: "IX_AdvertComments_AdvertId1",
                table: "AdvertComments");

            migrationBuilder.DropColumn(
                name: "AdvertId1",
                table: "AdvertComments");

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
                name: "PK_AdvertComments",
                table: "AdvertComments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertComments_AdvertId",
                table: "AdvertComments",
                column: "AdvertId");
        }
    }
}

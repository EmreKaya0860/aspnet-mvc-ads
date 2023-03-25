using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class userguid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userGuid",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userGuid",
                table: "Users");
        }
    }
}

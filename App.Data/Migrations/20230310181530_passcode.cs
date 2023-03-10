﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class passcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PasswordCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PasswordCodes_UserId",
                table: "PasswordCodes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordCodes");
        }
    }
}

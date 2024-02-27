using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KunschickMidterm452.Migrations
{
    /// <inheritdoc />
    public partial class AddingTablesAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Officers_OfficerId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Officers",
                table: "Officers");

            migrationBuilder.RenameTable(
                name: "Officers",
                newName: "Officer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Officer",
                table: "Officer",
                column: "OfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Officer_OfficerId",
                table: "Request",
                column: "OfficerId",
                principalTable: "Officer",
                principalColumn: "OfficerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Officer_OfficerId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Officer",
                table: "Officer");

            migrationBuilder.RenameTable(
                name: "Officer",
                newName: "Officers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Officers",
                table: "Officers",
                column: "OfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Officers_OfficerId",
                table: "Request",
                column: "OfficerId",
                principalTable: "Officers",
                principalColumn: "OfficerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

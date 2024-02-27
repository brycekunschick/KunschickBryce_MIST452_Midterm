using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KunschickMidterm452.Migrations
{
    /// <inheritdoc />
    public partial class FinalAddingTablesAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Officer_OfficerId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Request",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Officer",
                table: "Officer");

            migrationBuilder.RenameTable(
                name: "Request",
                newName: "Requests");

            migrationBuilder.RenameTable(
                name: "Officer",
                newName: "Officers");

            migrationBuilder.RenameIndex(
                name: "IX_Request_OfficerId",
                table: "Requests",
                newName: "IX_Requests_OfficerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Officers",
                table: "Officers",
                column: "OfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Officers_OfficerId",
                table: "Requests",
                column: "OfficerId",
                principalTable: "Officers",
                principalColumn: "OfficerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Officers_OfficerId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Officers",
                table: "Officers");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "Request");

            migrationBuilder.RenameTable(
                name: "Officers",
                newName: "Officer");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_OfficerId",
                table: "Request",
                newName: "IX_Request_OfficerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Request",
                table: "Request",
                column: "RequestId");

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
    }
}

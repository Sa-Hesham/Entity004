using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class AddRemoverRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AireCraft_AireLine_AireLineId",
                table: "AireCraft");

            migrationBuilder.RenameColumn(
                name: "AireLineId",
                table: "AireCraft",
                newName: "AireLineOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_AireCraft_AireLineId",
                table: "AireCraft",
                newName: "IX_AireCraft_AireLineOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AireCraft_AireLine_AireLineOwnerId",
                table: "AireCraft",
                column: "AireLineOwnerId",
                principalTable: "AireLine",
                principalColumn: "AireLineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AireCraft_AireLine_AireLineOwnerId",
                table: "AireCraft");

            migrationBuilder.RenameColumn(
                name: "AireLineOwnerId",
                table: "AireCraft",
                newName: "AireLineId");

            migrationBuilder.RenameIndex(
                name: "IX_AireCraft_AireLineOwnerId",
                table: "AireCraft",
                newName: "IX_AireCraft_AireLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_AireCraft_AireLine_AireLineId",
                table: "AireCraft",
                column: "AireLineId",
                principalTable: "AireLine",
                principalColumn: "AireLineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

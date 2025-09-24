using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AireCraft_AireLine_AireLineOwnerId",
                table: "AireCraft");

            migrationBuilder.AddForeignKey(
                name: "FK_AireCraft_AireLine_AireLineOwnerId",
                table: "AireCraft",
                column: "AireLineOwnerId",
                principalTable: "AireLine",
                principalColumn: "AireLineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AireCraft_AireLine_AireLineOwnerId",
                table: "AireCraft");

            migrationBuilder.AddForeignKey(
                name: "FK_AireCraft_AireLine_AireLineOwnerId",
                table: "AireCraft",
                column: "AireLineOwnerId",
                principalTable: "AireLine",
                principalColumn: "AireLineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

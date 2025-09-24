using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class AddrelationwithAireline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AireLineId",
                table: "AireCraft",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AireCraft_AireLineId",
                table: "AireCraft",
                column: "AireLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_AireCraft_AireLine_AireLineId",
                table: "AireCraft",
                column: "AireLineId",
                principalTable: "AireLine",
                principalColumn: "AireLineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AireCraft_AireLine_AireLineId",
                table: "AireCraft");

            migrationBuilder.DropIndex(
                name: "IX_AireCraft_AireLineId",
                table: "AireCraft");

            migrationBuilder.DropColumn(
                name: "AireLineId",
                table: "AireCraft");
        }
    }
}

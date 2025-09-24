using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class makeRelationbetweentranactionandAirline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AireLineId",
                table: "aireLineTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_aireLineTransaction_AireLineId",
                table: "aireLineTransaction",
                column: "AireLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_aireLineTransaction_AireLine_AireLineId",
                table: "aireLineTransaction",
                column: "AireLineId",
                principalTable: "AireLine",
                principalColumn: "AireLineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_aireLineTransaction_AireLine_AireLineId",
                table: "aireLineTransaction");

            migrationBuilder.DropIndex(
                name: "IX_aireLineTransaction_AireLineId",
                table: "aireLineTransaction");

            migrationBuilder.DropColumn(
                name: "AireLineId",
                table: "aireLineTransaction");
        }
    }
}

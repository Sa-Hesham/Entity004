using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationsbetweenAirelineandEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AireId",
                table: "employess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employess_AireId",
                table: "employess",
                column: "AireId");

            migrationBuilder.AddForeignKey(
                name: "FK_employess_AireLine_AireId",
                table: "employess",
                column: "AireId",
                principalTable: "AireLine",
                principalColumn: "AireLineId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employess_AireLine_AireId",
                table: "employess");

            migrationBuilder.DropIndex(
                name: "IX_employess_AireId",
                table: "employess");

            migrationBuilder.DropColumn(
                name: "AireId",
                table: "employess");
        }
    }
}

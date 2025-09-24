using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class AddPonetoAireline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Phonenumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AireLine_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => new { x.Phonenumber, x.AireLine_Id });
                    table.ForeignKey(
                        name: "FK_Phones_AireLine_AireLine_Id",
                        column: x => x.AireLine_Id,
                        principalTable: "AireLine",
                        principalColumn: "AireLineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_AireLine_Id",
                table: "Phones",
                column: "AireLine_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class addrange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AireLineId",
                table: "AireLine",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AireLineId",
                table: "AireLine",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 2")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}

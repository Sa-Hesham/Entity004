using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class editnme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "employess",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "employess",
                newName: "EmployeeName");
        }
    }
}

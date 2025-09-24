using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity003.Models.Migrations
{
    /// <inheritdoc />
    public partial class emplyeequalification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employeeQualifications",
                columns: table => new
                {
                    Qualificatons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeQualifications", x => new { x.EmployeeId, x.Qualificatons });
                    table.ForeignKey(
                        name: "FK_employeeQualifications_employess_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employess",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeQualifications");
        }
    }
}

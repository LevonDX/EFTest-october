using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTest_october.Migrations
{
    /// <inheritdoc />
    public partial class fixedmanytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Professions_ProfessionID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProfessionID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProfessionID",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeeProfession",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    professionsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfession", x => new { x.EmployeesID, x.professionsID });
                    table.ForeignKey(
                        name: "FK_EmployeeProfession_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProfession_Professions_professionsID",
                        column: x => x.professionsID,
                        principalTable: "Professions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfession_professionsID",
                table: "EmployeeProfession",
                column: "professionsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProfession");

            migrationBuilder.AddColumn<int>(
                name: "ProfessionID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProfessionID",
                table: "Employees",
                column: "ProfessionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Professions_ProfessionID",
                table: "Employees",
                column: "ProfessionID",
                principalTable: "Professions",
                principalColumn: "ID");
        }
    }
}

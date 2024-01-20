using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTest_october.Migrations
{
    /// <inheritdoc />
    public partial class ProfessionAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessionID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Professions_ProfessionID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProfessionID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProfessionID",
                table: "Employees");
        }
    }
}

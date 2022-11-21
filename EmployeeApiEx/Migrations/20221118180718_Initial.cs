using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeApiEx.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeInfos",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfos", x => x.EmployeeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeInfos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeApiEx.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailID",
                table: "EmployeeInfos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<long>(
                name: "Age",
                table: "EmployeeInfos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Int64),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailID",
                table: "EmployeeInfos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "EmployeeInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}

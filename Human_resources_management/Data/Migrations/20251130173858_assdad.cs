using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class assdad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "EmployItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Bonus",
                table: "EmployItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 2500 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 1200 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 1000 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 2200 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 900 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 1300 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 1500 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 1100 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 1400 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 2000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "EmployItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "EmployItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 2500.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 1200.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 1000.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 2200.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 900.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 1300.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 1500.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 1100.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 1400.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0m, 2000.0 });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class salaryHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hours",
                table: "EmployItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "EmployItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 2500.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 1200.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 1000.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 2200.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 900.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 1300.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 1500.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 1100.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 1400.0 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Hours", "Salary" },
                values: new object[] { 0, 2000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hours",
                table: "EmployItems");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "EmployItems");
        }
    }
}

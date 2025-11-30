using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class AddBonusToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Bonus",
                table: "EmployItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108,
                column: "Bonus",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109,
                column: "Bonus",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "EmployItems");
        }
    }
}

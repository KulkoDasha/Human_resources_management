using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class deLete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                column: "Status",
                value: "Уволен");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                column: "Status",
                value: "Активен");
        }
    }
}

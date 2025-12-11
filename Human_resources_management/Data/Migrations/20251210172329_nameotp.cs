using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class nameotp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Begin_otp",
                table: "EmployItems",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "End_otp",
                table: "EmployItems",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2025, 12, 10), new DateOnly(2025, 12, 17) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2025, 12, 18), new DateOnly(2025, 12, 25) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 1, 10), new DateOnly(2026, 1, 17) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 1, 18), new DateOnly(2026, 1, 25) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 1, 16), new DateOnly(2026, 2, 2) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 2, 3), new DateOnly(2026, 2, 9) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 2, 10), new DateOnly(2026, 2, 17) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 2, 18), new DateOnly(2026, 2, 25) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 3, 10), new DateOnly(2026, 3, 17) });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Begin_otp", "End_otp" },
                values: new object[] { new DateOnly(2026, 3, 18), new DateOnly(2026, 3, 25) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Begin_otp",
                table: "EmployItems");

            migrationBuilder.DropColumn(
                name: "End_otp",
                table: "EmployItems");
        }
    }
}

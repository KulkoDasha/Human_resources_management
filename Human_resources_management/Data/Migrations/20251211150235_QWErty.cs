using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class QWErty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "End_otp",
                table: "EmployItems",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Begin_otp",
                table: "EmployItems",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "HoursPerDay",
                table: "EmployItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalMonthlyHours",
                table: "EmployItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WorkingDays",
                table: "EmployItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "WorkingDaysMask",
                table: "EmployItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkingDaysPerWeek",
                table: "EmployItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ArchivedEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Job_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    Begin_otp = table.Column<DateOnly>(type: "date", nullable: true),
                    End_otp = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchivedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivedEmployees", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 8, 0, "Пн,Вт,Ср,Чт,Пт", 31, 5 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 8, 0, "Пн,Вт,Ср,Чт,Пт", 31, 5 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 6, 0, "Пн,Вт,Ср,Чт,Пт,Сб", 63, 6 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 6, 0, "Пн,Вт,Ср,Чт,Пт,Сб", 63, 6 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 10, 0, "Пн,Вт,Ср,Чт", 15, 4 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 10, 0, "Пн,Вт,Ср,Чт", 15, 4 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 8, 0, "Пн,Вт,Ср,Чт,Пт", 31, 5 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 8, 0, "Пн,Вт,Ср,Чт,Пт", 31, 5 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 10, 0, "Пн,Вт,Ср,Чт", 15, 4 });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "HoursPerDay", "TotalMonthlyHours", "WorkingDays", "WorkingDaysMask", "WorkingDaysPerWeek" },
                values: new object[] { 10, 0, "Пн,Вт,Ср,Чт", 15, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchivedEmployees");

            migrationBuilder.DropColumn(
                name: "HoursPerDay",
                table: "EmployItems");

            migrationBuilder.DropColumn(
                name: "TotalMonthlyHours",
                table: "EmployItems");

            migrationBuilder.DropColumn(
                name: "WorkingDays",
                table: "EmployItems");

            migrationBuilder.DropColumn(
                name: "WorkingDaysMask",
                table: "EmployItems");

            migrationBuilder.DropColumn(
                name: "WorkingDaysPerWeek",
                table: "EmployItems");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "End_otp",
                table: "EmployItems",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Begin_otp",
                table: "EmployItems",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);
        }
    }
}

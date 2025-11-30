using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class dannie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Job_Title", "Phone", "Status" },
                values: new object[] { "Руководитель отдела", "+7 (912) 399-39-80", "Отпуск" });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Phone", "Status" },
                values: new object[] { "+7 (922) 123-45-67", "Активен" });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "Phone",
                value: "+7 (989) 123-45-68");

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Job_Title", "Phone", "Status" },
                values: new object[] { "Ведущий разработчик", "+7 (922) 123-45-69", "Активен" });

            migrationBuilder.InsertData(
                table: "EmployItems",
                columns: new[] { "Id", "Birthday", "Email", "Job_Title", "Name", "Phone", "Status", "Surname" },
                values: new object[,]
                {
                    { 104, new DateOnly(1982, 5, 3), "dmitry.volkov@company.com", "Тестировщик", "Дмитрий", "+7 (495) 123-45-71", "Активен", "Волков" },
                    { 105, new DateOnly(2002, 8, 22), "elena.novikova@company.com", "Системный администратор", "Елена", "+7 (495) 123-45-72", "Активен", "Новикова" },
                    { 106, new DateOnly(2005, 11, 1), "anna.mikhailova@company.com", "Аналитик", "Анна", "+7 (495) 123-45-73", "Активен", "Михайлова" },
                    { 107, new DateOnly(2005, 12, 14), "sergey.orlov@company.com", "Дизайнер", "Сергей", "+7 (495) 123-45-74", "Болеет", "Орлов" },
                    { 108, new DateOnly(1994, 3, 10), "pavel.morozov@company.com", "Маркетолог", "Павел", "+7 (495) 123-45-75", "Отпуск", "Морозов" },
                    { 109, new DateOnly(2005, 5, 7), "igor@company.com", "Заместитель руководителя", "Игорь", "+7 (495) 123-45-76", "Активен", "Ивашкин" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Job_Title", "Phone", "Status" },
                values: new object[] { "Начальник", "89123993980", "В отпуске" });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Phone", "Status" },
                values: new object[] { "89991234456", "Работает" });

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "Phone",
                value: "89324347980");

            migrationBuilder.UpdateData(
                table: "EmployItems",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Job_Title", "Phone", "Status" },
                values: new object[] { "Программист", "89981235646", "Работает" });
        }
    }
}

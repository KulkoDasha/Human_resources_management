using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Human_resources_management.Migrations
{
    /// <inheritdoc />
    public partial class add_employitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<long>(type: "bigint", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Job_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EmployItems",
                columns: new[] { "Id", "Birthday", "Email", "Job_Title", "Name", "Phone", "Status", "Surname" },
                values: new object[,]
                {
                    { 100, new DateOnly(2006, 4, 10), "kulko.dasha.2006@gmail.com", "Начальник", "Даша", 89123993980L, "В отпуске", "Кулько" },
                    { 101, new DateOnly(2000, 2, 4), "ivan@company.com", "Менеджер", "Иван", 89991234456L, "Работает", "Петров" },
                    { 102, new DateOnly(1999, 10, 14), "maria@company.com", "Бухгалтер", "Мария", 89324347980L, "Болеет", "Сидорова" },
                    { 103, new DateOnly(2001, 7, 9), "sergey_2001@company.com", "Программист", "Сергей", 89981235646L, "Работает", "Иванов" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployItems");
        }
    }
}

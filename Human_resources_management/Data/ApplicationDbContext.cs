using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Human_resources_management.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Employee> EmployItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Employee>().HasData([
                new Employee {Id = 100, Name = "Даша", Surname = "Кулько",
                Phone = "+7 (912) 399-39-80", Email = "kulko.dasha.2006@gmail.com",
                Birthday =  new DateOnly(2006, 4, 10),
                Job_Title = "Руководитель отдела", Status ="Отпуск",
                    Begin_otp = new DateOnly(2025, 12, 10), End_otp = new DateOnly(2025, 12, 17), 
                    Hours=1,Salary=2500,
                WorkingDaysPerWeek = 5,
                HoursPerDay = 8,
                WorkingDaysMask = 31, // 1+2+4+8+16 = Пн-Пт (5/2)
                WorkingDays = "Пн,Вт,Ср,Чт,Пт"
                },
                new Employee {Id = 101, Name = "Иван", Surname = "Петров",
                Phone = "+7 (922) 123-45-67", Email = "ivan@company.com",
                Birthday =  new DateOnly(2000, 2, 4),
                Job_Title = "Менеджер", Status ="Активен",
                WorkingDaysPerWeek = 5,
                HoursPerDay = 8,
                WorkingDaysMask = 31, // 1+2+4+8+16 = Пн-Пт (5/2)
                WorkingDays = "Пн,Вт,Ср,Чт,Пт",
                    Begin_otp = new DateOnly(2025, 12, 18), End_otp = new DateOnly(2025, 12, 25),
                    Hours=1,Salary=1200},
                new Employee {Id = 102, Name = "Мария", Surname = "Сидорова",
                Phone = "+7 (989) 123-45-68", Email = "maria@company.com",
                Birthday =  new DateOnly(1999, 10, 14),
                    Begin_otp = new DateOnly(2026, 01, 10), End_otp = new DateOnly(2026, 01, 17),
                    WorkingDaysPerWeek = 6,
                    HoursPerDay = 6,
                    WorkingDaysMask = 63, // 1+2+4+8+16+32 = Пн-Сб (6/1)
                    WorkingDays = "Пн,Вт,Ср,Чт,Пт,Сб",
                Job_Title = "Бухгалтер", Status ="Болеет",Hours=1,Salary=1000},
                new Employee {Id = 103, Name = "Сергей", Surname = "Иванов",
                Phone = "+7 (922) 123-45-69", Email = "sergey_2001@company.com",
                Birthday =  new DateOnly(2001, 7, 9),
                    Begin_otp = new DateOnly(2026, 01, 18), End_otp = new DateOnly(2026, 01, 25),
                    WorkingDaysPerWeek = 6,
                    HoursPerDay = 6,
                    WorkingDaysMask = 63, // 1+2+4+8+16+32 = Пн-Сб (6/1)
                    WorkingDays = "Пн,Вт,Ср,Чт,Пт,Сб",
                Job_Title = "Ведущий разработчик", Status ="Активен",Hours=1,Salary=2200},
                new Employee {Id = 104, Name = "Дмитрий", Surname = "Волков",
                Phone = "+7 (495) 123-45-71", Email = "dmitry.volkov@company.com",
                Birthday =  new DateOnly(1982, 5, 3),
                    Begin_otp = new DateOnly(2026, 01, 16), End_otp = new DateOnly(2026, 02, 2),
                    WorkingDaysPerWeek = 4,
                    HoursPerDay = 10,
                    WorkingDaysMask = 15, // 1+2+4+8 = Пн-Чт (4/3)
                    WorkingDays = "Пн,Вт,Ср,Чт",
                Job_Title = "Тестировщик", Status ="Активен",Hours=1,Salary=900},
                new Employee {Id = 105, Name = "Елена", Surname = "Новикова",
                Phone = "+7 (495) 123-45-72", Email = "elena.novikova@company.com",
                Birthday =  new DateOnly(2002, 8, 22),
                    Begin_otp = new DateOnly(2026, 02, 03), End_otp = new DateOnly(2026, 02, 09),
                    WorkingDaysPerWeek = 4,
                    HoursPerDay = 10,
                    WorkingDaysMask = 15, // 1+2+4+8 = Пн-Чт (4/3)
                    WorkingDays = "Пн,Вт,Ср,Чт",
                Job_Title = "Системный администратор", Status ="Уволен",Hours=1,Salary=1300},
                new Employee {Id = 106, Name = "Анна", Surname = "Михайлова",
                Phone = "+7 (495) 123-45-73", Email = "anna.mikhailova@company.com",
                Birthday =  new DateOnly(2005, 11, 1),
                    Begin_otp = new DateOnly(2026, 02, 10), End_otp = new DateOnly(2026, 02, 17),
                    WorkingDaysPerWeek = 5,
                    HoursPerDay = 8,
                    WorkingDaysMask = 31, // 1+2+4+8+16 = Пн-Пт (5/2)
                    WorkingDays = "Пн,Вт,Ср,Чт,Пт",
                Job_Title = "Аналитик", Status ="Активен",Hours=1,Salary=1500},
                new Employee {Id = 107, Name = "Сергей", Surname = "Орлов",
                Phone = "+7 (495) 123-45-74", Email = "sergey.orlov@company.com",
                Birthday =  new DateOnly(2005, 12, 14),
                    Begin_otp = new DateOnly(2026, 02, 18), End_otp = new DateOnly(2026, 02, 25),
                    WorkingDaysPerWeek = 5,
                    HoursPerDay = 8,
                    WorkingDaysMask = 31, // 1+2+4+8+16 = Пн-Пт (5/2)
                    WorkingDays = "Пн,Вт,Ср,Чт,Пт",
                Job_Title = "Дизайнер", Status ="Болеет",Hours=1,Salary=1100},
                new Employee {Id = 108, Name = "Павел", Surname = "Морозов",
                Phone = "+7 (495) 123-45-75", Email = "pavel.morozov@company.com",
                Birthday =  new DateOnly(1994, 3, 10),
                    Begin_otp = new DateOnly(2026, 03, 10), End_otp = new DateOnly(2026, 03, 17),
                    WorkingDaysPerWeek = 4,
                    HoursPerDay = 10,
                    WorkingDaysMask = 15, // 1+2+4+8 = Пн-Чт (4/3)
                    WorkingDays = "Пн,Вт,Ср,Чт",
                Job_Title = "Маркетолог", Status ="Отпуск",Hours=1,Salary=1400},
                new Employee {Id = 109, Name = "Игорь", Surname = "Ивашкин",
                Phone = "+7 (495) 123-45-76", Email = "igor@company.com",
                Birthday =  new DateOnly(2005, 5, 7),
                    Begin_otp = new DateOnly(2026, 03, 18), End_otp = new DateOnly(2026, 03, 25),
                    WorkingDaysPerWeek = 4,
                    HoursPerDay = 10,
                    WorkingDaysMask = 15, // 1+2+4+8 = Пн-Чт (4/3)
                    WorkingDays = "Пн,Вт,Ср,Чт",
                Job_Title = "Заместитель руководителя", Status ="Активен",Hours=1,Salary=2000}]);
        }
        public virtual DbSet<ArchivedEmployee> ArchivedEmployees { get; set; }
    }
}

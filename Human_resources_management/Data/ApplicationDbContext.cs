using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
                Job_Title = "Руководитель отдела", Status ="Отпуск",Hours=1,Salary=2500},
                new Employee {Id = 101, Name = "Иван", Surname = "Петров",
                Phone = "+7 (922) 123-45-67", Email = "ivan@company.com",
                Birthday =  new DateOnly(2000, 2, 4),
                Job_Title = "Менеджер", Status ="Активен",Hours=1,Salary=1200},
                new Employee {Id = 102, Name = "Мария", Surname = "Сидорова",
                Phone = "+7 (989) 123-45-68", Email = "maria@company.com",
                Birthday =  new DateOnly(1999, 10, 14),
                Job_Title = "Бухгалтер", Status ="Болеет",Hours=1,Salary=1000},
                new Employee {Id = 103, Name = "Сергей", Surname = "Иванов",
                Phone = "+7 (922) 123-45-69", Email = "sergey_2001@company.com",
                Birthday =  new DateOnly(2001, 7, 9),
                Job_Title = "Ведущий разработчик", Status ="Активен",Hours=1,Salary=2200},
                new Employee {Id = 104, Name = "Дмитрий", Surname = "Волков",
                Phone = "+7 (495) 123-45-71", Email = "dmitry.volkov@company.com",
                Birthday =  new DateOnly(1982, 5, 3),
                Job_Title = "Тестировщик", Status ="Активен",Hours=1,Salary=900},
                new Employee {Id = 105, Name = "Елена", Surname = "Новикова",
                Phone = "+7 (495) 123-45-72", Email = "elena.novikova@company.com",
                Birthday =  new DateOnly(2002, 8, 22),
                Job_Title = "Системный администратор", Status ="Уволен",Hours=1,Salary=1300},
                new Employee {Id = 106, Name = "Анна", Surname = "Михайлова",
                Phone = "+7 (495) 123-45-73", Email = "anna.mikhailova@company.com",
                Birthday =  new DateOnly(2005, 11, 1),
                Job_Title = "Аналитик", Status ="Активен",Hours=1,Salary=1500},
                new Employee {Id = 107, Name = "Сергей", Surname = "Орлов",
                Phone = "+7 (495) 123-45-74", Email = "sergey.orlov@company.com",
                Birthday =  new DateOnly(2005, 12, 14),
                Job_Title = "Дизайнер", Status ="Болеет",Hours=1,Salary=1100},
                new Employee {Id = 108, Name = "Павел", Surname = "Морозов",
                Phone = "+7 (495) 123-45-75", Email = "pavel.morozov@company.com",
                Birthday =  new DateOnly(1994, 3, 10),
                Job_Title = "Маркетолог", Status ="Отпуск",Hours=1,Salary=1400},
                new Employee {Id = 109, Name = "Игорь", Surname = "Ивашкин",
                Phone = "+7 (495) 123-45-76", Email = "igor@company.com",
                Birthday =  new DateOnly(2005, 5, 7),
                Job_Title = "Заместитель руководителя", Status ="Активен",Hours=1,Salary=2000}]);
        }
    }
}

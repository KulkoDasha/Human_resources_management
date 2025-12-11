using Human_resources_management.Data.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace Human_resources_management.Data.Services
{
    public class MSSQLDataService : IEmployeeServicecs
    {
        private readonly ApplicationDbContext _context;
        private readonly NavigationManager _navigationManager;
        private readonly IJSRuntime _jsRuntime;

        // Добавляем зависимости в конструктор
        public MSSQLDataService(ApplicationDbContext context,
                               NavigationManager navigationManager,
                               IJSRuntime jsRuntime)
        {
            _context = context;
            _navigationManager = navigationManager;
            _jsRuntime = jsRuntime;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            // Показываем только не уволенных
            return await _context.EmployItems
                .Where(e => e.Status != "Уволен") // Фильтруем уволенных
                .ToListAsync();
        }

        // Новый метод для получения всех (включая уволенных)
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.EmployItems.ToListAsync();
        }

        // Метод для получения архивных (уволенных)
        public async Task<IEnumerable<Employee>> GetArchivedEmployeesAsync()
        {
            return await _context.EmployItems
                .Where(e => e.Status == "Уволен")
                .ToListAsync();
        }

        public async Task<Employee?> GetEmployeeAsync(int id)
        {
            return await _context.EmployItems
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        // Удаляем дубликат метода UpdateEmployeeAsync
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            var existingEmployee = await _context.EmployItems
                .FirstOrDefaultAsync(e => e.Id == employee.Id);

            if (existingEmployee != null)
            {
                // Сохраняем старый статус для проверки
                var oldStatus = existingEmployee.Status;
                var newStatus = employee.Status;

                // Обновляем свойства
                existingEmployee.Name = employee.Name;
                existingEmployee.Surname = employee.Surname;
                existingEmployee.Phone = employee.Phone;
                existingEmployee.Email = employee.Email;
                existingEmployee.Birthday = employee.Birthday;
                existingEmployee.Job_Title = employee.Job_Title;
                existingEmployee.Status = employee.Status;
                existingEmployee.Salary = employee.Salary; // Добавьте если есть
                existingEmployee.Hours = employee.Hours;   // Добавьте если есть
                existingEmployee.Begin_otp = employee.Begin_otp; // Добавьте если есть
                existingEmployee.End_otp = employee.End_otp;     // Добавьте если есть

                await _context.SaveChangesAsync();

                // Проверяем, был ли сотрудник уволен
                if (oldStatus != "Уволен" && newStatus == "Уволен")
                {
                    // Можно вернуть флаг или сделать отдельный метод для архивации
                    // Но НЕ вызываем навигацию и JS из сервиса!
                    // Эту логику лучше делать в компоненте
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _context.EmployItems
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee != null)
            {
                _context.EmployItems.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        // Метод для мягкого удаления (архивации)
        public async Task<bool> ArchiveEmployeeAsync(int id, string reason = "")
        {
            var employee = await _context.EmployItems
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null) return false;

            // Меняем статус на "Уволен"
            employee.Status = "Уволен";

            // Можно добавить поле для причины увольнения
            // employee.DismissalReason = reason;
            // employee.DismissalDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Employee>> GetEmployItemAsync()
        {
            return await GetEmployeesAsync(); // Используем тот же метод
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            try
            {
                if (employee.Id == 0)
                {
                    // Автоматическая генерация ID
                    if (!_context.EmployItems.Any())
                    {
                        employee.Id = 1;
                    }
                    else
                    {
                        employee.Id = await _context.EmployItems.MaxAsync(e => e.Id) + 1;
                    }

                    await _context.EmployItems.AddAsync(employee);
                }
                else
                {
                    _context.EmployItems.Update(employee);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при добавлении сотрудника: {ex.Message}", ex);
            }
        }

        public async Task<EmployeeStatistics> GetEmployeeStatisticsAsync(int employeeId)
        {
            var employees = await GetAllEmployeesAsync(); // Берем всех сотрудников

            // Исправляем дубликаты в проверках
            return new EmployeeStatistics
            {
                TotalEmployees = employees.Count(),
                ActiveEmployees = employees.Count(e => e.Status == "Активен"),
                OnVacation = employees.Count(e => e.Status == "Отпуск"),
                OnSickLeave = employees.Count(e => e.Status == "Болеет"),
                Dismissed = employees.Count(e => e.Status == "Уволен")
            };
        }

        public async Task SaveEmployeesWorkHoursAsync(List<Employee> employees)
        {
            var allDbEmployees = await _context.EmployItems.ToListAsync();

            foreach (var dbEmployee in allDbEmployees)
            {
                var updatedEmployee = employees.FirstOrDefault(e => e.Id == dbEmployee.Id);
                if (updatedEmployee != null)
                {
                    dbEmployee.Hours = updatedEmployee.Hours;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}

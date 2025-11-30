using Human_resources_management.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Human_resources_management.Data.Services
{
    public class MSSQLDataService : IEmployeeServicecs
    {
        private readonly ApplicationDbContext _context;

        public MSSQLDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.EmployItems.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeAsync(int id)
        {
            return await _context.EmployItems
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            var existingEmployee = await _context.EmployItems
                .FirstOrDefaultAsync(e => e.Id == employee.Id);

            if (existingEmployee != null)
            {
                // Обновляем свойства
                existingEmployee.Name = employee.Name;
                existingEmployee.Surname = employee.Surname;
                existingEmployee.Phone = employee.Phone;
                existingEmployee.Email = employee.Email;
                existingEmployee.Birthday = employee.Birthday;
                existingEmployee.Job_Title = employee.Job_Title;
                existingEmployee.Status = employee.Status;

                await _context.SaveChangesAsync();
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

        public async Task<IEnumerable<Employee>> GetEmployItemAsync()
        {
            return await _context.EmployItems.ToListAsync();
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            try
            {
                if (employee.Id == 0)
                {
                    await _context.EmployItems.AddAsync(employee);
                }
                else
                {
                    _context.EmployItems.Update(employee);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<EmployeeStatistics> GetEmployeeStatisticsAsync(int employeeId)
        {
            var employees = await _context.EmployItems.ToListAsync();

            return new EmployeeStatistics
            {
                TotalEmployees = employees.Count,
                ActiveEmployees = employees.Count(e => e.Status == "Активен" || e.Status == "Активен"),
                OnVacation = employees.Count(e => e.Status == "Отпуск" || e.Status == "Отпуск"),
                OnSickLeave = employees.Count(e => e.Status == "Болеет"),
                Dismissed = employees.Count(e => e.Status == "Уволен")
            };
        }

        public async Task SaveEmployeesWorkHoursAsync(List<Employee> employees)
        {
            var allDbEmployees = await _context.EmployItems.ToListAsync();

            // Обновляем только тех, у кого есть часы в переданном списке
            foreach (var dbEmployee in allDbEmployees)
            {
                var updatedEmployee = employees.FirstOrDefault(e => e.Id == dbEmployee.Id);
                if (updatedEmployee != null)
                {
                    dbEmployee.Hours = updatedEmployee.Hours;
                }
                // Если сотрудника нет в списке - НЕ трогаем его часы!
            }

            await _context.SaveChangesAsync();
        }
    }
}

using Human_resources_management.Components.Pages;

namespace Human_resources_management.Data.Interfaces
{
    public interface IEmployeeServicecs
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync(); // Только не уволенных
        Task<IEnumerable<Employee>> GetAllEmployeesAsync(); // Всех сотрудников
        Task<IEnumerable<Employee>> GetArchivedEmployeesAsync(); // Только уволенных
        Task<Employee?> GetEmployeeAsync(int id);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteAsync(int id);
        Task<bool> ArchiveEmployeeAsync(int id, string reason = "");
        Task AddEmployeeAsync(Employee employee);
        Task<EmployeeStatistics> GetEmployeeStatisticsAsync(int employeeId);
        Task SaveEmployeesWorkHoursAsync(List<Employee> employees);

    }
    public class EmployeeStatistics
    {
        public int TotalEmployees { get; set; }
        public int ActiveEmployees { get; set; }
        public int OnVacation { get; set; }
        public int OnSickLeave { get; set; }
        public int Dismissed { get; set; }
    }
}

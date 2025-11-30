using Human_resources_management.Components.Pages;

namespace Human_resources_management.Data.Interfaces
{
    public interface IEmployeeServicecs
    {
        Task AddEmployeeAsync(Employee employee);
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee?> GetEmployeeAsync(int id);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteAsync(int id);
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

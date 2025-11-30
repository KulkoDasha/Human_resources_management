using Human_resources_management.Data.Interfaces;

namespace Human_resources_management.Data.Services
{
    public class MemoryDataServices 
    {
        private static readonly List<Employee> employes =
        [
            new() {
                Id = 100,
                Name = "Даша",
                Surname = "Кулько",
                Phone = "89123993980",
                Email = "kulko.dasha.2006@gmail.com",
                Birthday = new DateOnly(2006, 4, 10),
                Job_Title = "Начальник",
                Status = "Отпуск"
            },
            new() {
                Id = 101,
                Name = "Иван",
                Surname = "Петров",
                Phone = "89991234456",
                Email = "ivan@company.com",
                Birthday = new DateOnly(2000, 2, 4),
                Job_Title = "Менеджер",
                Status = "Активен"
            },
            new() {
                Id = 102,
                Name = "Мария",
                Surname = "Сидорова",
                Phone = "89324347980",
                Email = "maria@company.com",
                Birthday = new DateOnly(1999, 10, 14),
                Job_Title = "Бухгалтер",
                Status = "Болеет"
            },
        ];

        public Task<IEnumerable<Employee>> GetEmployItemAsync()
        {
            return Task.FromResult(employes.AsEnumerable());
        }

        // Дополнительные методы для CRUD операций
        public Task<Employee?> GetEmployItemAsync(int id)
        {
            return Task.FromResult(employes.FirstOrDefault(e => e.Id == id));
        }

        public Task AddEmployItemAsync(Employee item)
        {
            // Генерируем новый ID
            item.Id = employes.Count != 0 ? employes.Max(e => e.Id) + 1 : 1;
            employes.Add(item);
            return Task.CompletedTask;
        }

        public Task UpdateEmployItemAsync(Employee item)
        {
            var existing = employes.FirstOrDefault(e => e.Id == item.Id);
            if (existing != null)
            {
                existing.Name = item.Name;
                existing.Surname = item.Surname;
                existing.Phone = item.Phone;
                existing.Email = item.Email;
                existing.Birthday = item.Birthday;
                existing.Job_Title = item.Job_Title;
                existing.Status = item.Status;
            }
            return Task.CompletedTask;
        }

        public Task DeleteEmployItemAsync(int id)
        {
            var item = employes.FirstOrDefault(e => e.Id == id);
            if (item != null)
            {
                employes.Remove(item);
            }
            return Task.CompletedTask;
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Human_resources_management.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateOnly? Birthday { get; set; }
        public string? Job_Title { get; set; }
        public string? Status { get; set; }
        public int Hours { get; set; }
        public DateOnly? Begin_otp { get; set; }
        public DateOnly? End_otp { get; set; }
        public int Salary { get; set; }
        public int Bonus { get; set; }

        public int WorkingDaysPerWeek { get; set; } = 5;
        public int HoursPerDay { get; set; } = 8;
        public int TotalMonthlyHours { get; set; }
        public string WorkingDays { get; set; } = "Пн,Вт,Ср,Чт,Пт,Сб";
        public int WorkingDaysMask { get; set; } = 31;
        [NotMapped]
        public List<string> WorkingDaysList
        {
            get
            {
                var days = new List<string>();
                var dayNames = new[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

                for (int i = 0; i < 7; i++)
                {
                    if ((WorkingDaysMask & (1 << i)) != 0)
                    {
                        days.Add(dayNames[i]);
                    }
                }
                return days;
            }

        }
        public bool WorksOnDay(int dayIndex) // 0 - Пн, 1 - Вт, ... 6 - Вс
        {
            return (WorkingDaysMask & (1 << dayIndex)) != 0;
        }
    }
    public static class WorkingDaysHelper
    {
        public static readonly Dictionary<int, string> DayNames = new()
    {
        { 0, "Понедельник" },
        { 1, "Вторник" },
        { 2, "Среда" },
        { 3, "Четверг" },
        { 4, "Пятница" },
        { 5, "Суббота" },
        { 6, "Воскресенье" }
    };

        public static readonly Dictionary<int, string> ShortDayNames = new()
    {
        { 0, "Пн" },
        { 1, "Вт" },
        { 2, "Ср" },
        { 3, "Чт" },
        { 4, "Пт" },
        { 5, "Сб" },
        { 6, "Вс" }
    };

        // Получить список дней по маске
        public static List<string> GetWorkingDays(int mask)
        {
            var days = new List<string>();
            for (int i = 0; i < 7; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    days.Add(ShortDayNames[i]);
                }
            }
            return days;
        }

        // Проверить, является ли день выходным
        public static bool IsWeekend(int dayIndex)
        {
            return dayIndex == 5 || dayIndex == 6; // Суббота или воскресенье
        }

        // Сгенерировать маску из списка дней
        public static int GenerateMask(List<int> dayIndexes)
        {
            int mask = 0;
            foreach (var index in dayIndexes)
            {
                if (index >= 0 && index < 7)
                {
                    mask |= (1 << index);
                }
            }
            return mask;
        }
    }
}

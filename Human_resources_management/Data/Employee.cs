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
        public int Salary { get; set; }
        public int Bonus { get; set; }
    }
}

namespace Human_resources_management.Data
{
    public class ArchivedEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly? Birthday { get; set; }
        public string Job_Title { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int Hours { get; set; }
        public DateOnly? Begin_otp { get; set; }
        public DateOnly? End_otp { get; set; }
        public string Status { get; set; } = "Уволен";
        public DateTime ArchivedDate { get; set; } = DateTime.Now; 
    }
}

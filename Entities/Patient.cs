namespace prescription_management_sandbox_api.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Gender { get; set; }

        public DateOnly BirthDay { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
    }
}

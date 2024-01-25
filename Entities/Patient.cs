namespace prescription_management_sandbox_api.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;

        public DateOnly BirthDay { get; set; }

        public string Address { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;
    }
}

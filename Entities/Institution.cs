namespace prescription_management_sandbox_api.Entities
{
    public class Institution
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Address { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;
    }
}

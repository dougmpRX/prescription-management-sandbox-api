namespace prescription_management_sandbox_api.Entities
{
    public class Professional
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Profession { get; set; } = String.Empty;

        public string RegistryType {  get; set; } = String.Empty;

        public int ResgistryNumber { get; set; }
    }
}

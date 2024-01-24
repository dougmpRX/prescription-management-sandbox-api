namespace prescription_management_sandbox_api.Entities
{
    public class Medicine
    {
        public int Id { get; set; }

        public string? Class { get; set; }

        public string? Type { get; set; }

        public string? Name { get; set; }

        public double Dosage { get; set; }

        public string? UsageDescription { get; set; }
    }
}
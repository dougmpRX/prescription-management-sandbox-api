namespace prescription_management_sandbox_api.Entities
{
    public class Medicine
    {
        public int Id { get; set; }

        public string Class { get; set; } = String.Empty;

        public string Type { get; set; } = String.Empty;

        public string Name { get; set; } = String.Empty;

        public double Dosage { get; set; }

        public string UsageDescription { get; set; } = String.Empty;
    }
}
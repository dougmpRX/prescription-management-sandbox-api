namespace prescription_management_sandbox_api.Entities
{
    public class Prescription
    {
        public int Id { get; set; }

        public string Type { get; set; } = String.Empty;

        public Patient Patient { get; set; } = new Patient();

        public IEnumerable<Medicine> Medicines { get; set; } = Enumerable.Empty<Medicine>();

        public DateTime Date { get; set; }

        public Professional Professional { get; set; } = new Professional();

        public Institution Institution { get; set; } = new Institution();
    }
}

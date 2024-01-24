namespace prescription_management_sandbox_api.Entities
{
    public class Prescription
    {
        public int Id { get; set; }

        public string? Type { get; set; }

        public Patient? Patient { get; set; }

        public IEnumerable<Medicine>? Medicines { get; set; }

        public DateTime Date { get; set; }

        public Professional? Professional { get; set; }

        public Institution? Institution { get; set; }
    }
}

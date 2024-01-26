using prescription_management_sandbox_api.Enums;

namespace prescription_management_sandbox_api.Entities
{
    public class Medicine
    {
        public int Id { get; set; }

        public MedicineCategoryEnum Category { get; set; } = MedicineCategoryEnum.WITHOUT_RETENTION;

        public string Name { get; set; } = String.Empty;

        public double Dosage { get; set; }

        public string DosageUnit { get; set; } = String.Empty;

        public string UsageDescription { get; set; } = String.Empty;

        public IEnumerable<PrescriptionMedicine> PrescriptionMedicines { get; set; } = 
            Enumerable.Empty<PrescriptionMedicine>();
    }
}
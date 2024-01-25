using prescription_management_sandbox_api.Enums;

namespace prescription_management_sandbox_api.Entities
{
    public class Prescription
    {
        public int Id { get; set; }

        public PrescriptionTypeEnum Type { get; set; } = PrescriptionTypeEnum.SIMPLE;

        public DateTime Date { get; set; }

        public Patient Patient { get; set; } = new Patient();

        public Professional Professional { get; set; } = new Professional();

        public Institution Institution { get; set; } = new Institution();

        public IEnumerable<PrescriptionMedicine> PrescriptionMedicines { get; set; } =
            Enumerable.Empty<PrescriptionMedicine>();
    }
}

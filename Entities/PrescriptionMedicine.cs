namespace prescription_management_sandbox_api.Entities
{
    public class PrescriptionMedicine
    {
        public int PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}

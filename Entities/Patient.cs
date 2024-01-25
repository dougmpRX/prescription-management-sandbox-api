using prescription_management_sandbox_api.Enums;

namespace prescription_management_sandbox_api.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string CPF { get; set; } = String.Empty;

        public PatientGender Gender { get; set; } = PatientGender.UNDEFINED;

        public DateOnly BirthDay { get; set; }

        public string Address { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public IEnumerable<Prescription> Prescriptions { get; set; } = Enumerable.Empty<Prescription>();
    }
}

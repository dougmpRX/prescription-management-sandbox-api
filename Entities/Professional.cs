using prescription_management_sandbox_api.Enums;

namespace prescription_management_sandbox_api.Entities
{
    public class Professional
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public ProfessionalTypeEnum Category { get; set; } = ProfessionalTypeEnum.MEDIC;

        public ProfessionalRegistryEnum RegistryType { get; set; } = ProfessionalRegistryEnum.CRM;

        public ProfessionalRegistryStateEnum RegistryState { get; set; } = ProfessionalRegistryStateEnum.MG;

        public int ResgistryNumber { get; set; }

        public IEnumerable<Prescription> Prescriptions { get; set; } = Enumerable.Empty<Prescription>();
    }
}

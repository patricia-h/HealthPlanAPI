namespace HealthPlanAPI.Models
{
    public class Beneficiary
    {
        //[Key]
        public int BeneficiaryId { get; set; }

        public long TaxNumber { get; set; }

        //[StringLength(100)]
        public string? Name { get; set; }

        public DateTime AdmissionDate { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public int MeditatedHours { get; set; }

        public int PlanId { get; set; }

        public Plan? Plan { get; set; }
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthPlanAPI.Models
{
    public class Plan
    {
        public Plan()
        {
            Beneficiaries = new Collection<Beneficiary>();
        }


        [Key]
        public int PlanId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public PlanType Type { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Value { get; set; }

        public int PlanOperatorId { get; set; }

        public PlanOperator? PlanOperator { get; set; }

        public ICollection<Beneficiary>? Beneficiaries
        {
            get; set;
        }
    }
}

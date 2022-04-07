using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HealthPlanAPI.Models
{
    public class PlanOperator
    {
        public PlanOperator()
        {
            Plans = new Collection<Plan>();
        }

        [Key]
        public int PlanOperatorId { get; set; }

        public long TaxNumber { get; set; }

        [StringLength(100)]
        public string? CompanyName { get; set; }

        [MaxLength(100)]
        public string? TradingName { get; set; }

        [StringLength(100)]
        public string? Address { get; set; }

        public PlanOperatorType Type { get; set; }

        public ICollection<Plan>? Plans { get; set; }
    }
}

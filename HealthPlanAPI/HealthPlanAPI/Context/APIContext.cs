using HealthPlanAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthPlanAPI.Context
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
        public DbSet<Beneficiary>? Beneficiary { get; set; }
        public DbSet<Plan>? Plan { get; set; }
        public DbSet<PlanOperator>? PlanOperator { get; set; }
    }
}

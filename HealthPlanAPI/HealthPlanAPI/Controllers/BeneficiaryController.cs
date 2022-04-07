using HealthPlanAPI.Context;
using HealthPlanAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthPlanAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BeneficiaryController : ControllerBase
    {
        private readonly APIContext _context;

        public BeneficiaryController(APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Beneficiary>> Get()
        {
            var beneficiaries = _context.Beneficiary.ToList();
            if (beneficiaries is null)
            {
                return NotFound("Beneficiaries not found");
            }
            return beneficiaries;
        }
    }
}

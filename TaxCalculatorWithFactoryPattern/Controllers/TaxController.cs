using Microsoft.AspNetCore.Mvc;
using TaxCalculatorWithFactoryPattern.Infrastructure.Interfaces;

namespace TaxCalculatorWithFactoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILogger<TaxController> _logger;

        public TaxController(ITaxCalculatorService taxCalculatorService, ILogger<TaxController> logger)
        {
            _taxCalculatorService = taxCalculatorService;
            _logger = logger;
        }
        [HttpPost]
        [Route("Tax-Calculator")]
        public ActionResult<double> TaxCalculator(string type, double amount)
        {
            var errors = new List<string>();
            if(string.IsNullOrWhiteSpace(type))
            {
                errors.Add(type);
            }
            if(amount < 30000)
            {
                errors.Add($"{amount} The amount must be more than 30000");
                return BadRequest(errors);
            }
            else
            {
                var tax = _taxCalculatorService.TaxCalculator(type, amount);
                return Ok($"The tax due is { tax}");
            }
            
        }
    }
}

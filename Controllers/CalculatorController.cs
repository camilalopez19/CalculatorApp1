using Microsoft.AspNetCore.Mvc;   // Necesario para ControllerBase, IActionResult, Route, ApiController, FromQuery

namespace CalculatorApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new { a, b, result });
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/calculator/sum?a=5&b=3
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            int result = a + b;
            return Ok(new { a, b, result });
        }

        // GET: api/calculator/subtract?a=5&b=3
        [HttpGet("subtract")]
        public IActionResult GetSubtract([FromQuery] int a, [FromQuery] int b)
        {
            int result = a - b;
            return Ok(new { a, b, result });
        }

        // GET: api/calculator/multiply?a=5&b=3
        [HttpGet("multiply")]
        public IActionResult GetMultiply([FromQuery] int a, [FromQuery] int b)
        {
            int result = a * b;
            return Ok(new { a, b, result });
        }

        // GET: api/calculator/divide?a=6&b=3
        [HttpGet("divide")]
        public IActionResult GetDivide([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
                return BadRequest("No se puede dividir entre cero.");

            double result = (double)a / b;
            return Ok(new { a, b, result });
        }
    }
}
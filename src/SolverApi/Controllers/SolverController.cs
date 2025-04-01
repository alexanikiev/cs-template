using Microsoft.AspNetCore.Mvc;
using SolverApi.Models;
using System.ComponentModel.DataAnnotations;

namespace SolverApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolverController : ControllerBase
    {
        [HttpGet("{x}/{y}")]
        public IActionResult Get(int x, int y)
        {
            var solver = new Solver("a", "b");
            int result = solver.Solve(x, y);
            return Ok(new { result });
        }

        [HttpPost]
        public IActionResult Post([FromBody] SolverInput input)
        {
            var solver = new Solver(input.A, input.B);
            int result = solver.Solve(input.X, input.Y);
            return Ok(new { result });
        }
    }

    public class SolverInput
    {
        [Required]
        public string A { get; set; } = string.Empty;

        [Required]
        public string B { get; set; } = string.Empty;

        public int X { get; set; }
        public int Y { get; set; }
    }
}

using System;
using Microsoft.Extensions.Logging;

namespace SolverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .SetMinimumLevel(LogLevel.Information)
                    .AddConsole();
            });

            ILogger logger = loggerFactory.CreateLogger<Program>();

            var solver = new Solver("a", "b");

            int x = 3;
            int y = 4;

            try
            {
                logger.LogInformation("Solving with x={x} and y={y}", x, y);
                int result = solver.Solve(x, y);
                logger.LogInformation("Result: {result}", result);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while solving.");
            }
        }
    }
}

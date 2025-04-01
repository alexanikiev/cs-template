using SolverApp;
using System;

namespace SolverWorker
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var solver = new Solver("a", "b");

            int x = 3;
            int y = 4;

            try
            {
                Console.WriteLine($"Solving with x={x} and y={y}");
                int result = solver.Solve(x, y);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            await Worker.AsyncSolve(solver, x, y);
        }
    }
}

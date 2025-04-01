using System;
using System.Threading.Tasks;

namespace SolverApp
{
    public static class Worker
    {
        public static async Task AsyncSolve(Solver solver, int x, int y)
        {
            var result = await Task.Run(() => solver.Solve(x, y));
            Console.WriteLine($"Async result: {result}");
        }
    }
}

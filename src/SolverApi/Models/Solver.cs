namespace SolverApi.Models
{
    public class Solver
    {
        public string A { get; }
        public string B { get; }

        public Solver(string a, string b)
        {
            A = a;
            B = b;
        }

        private int Calculate(int x, int y)
        {
            return x * y;
        }

        public int Solve(int x, int y)
        {
            return Calculate(x, y);
        }

        public void Error()
        {
            throw new Exception("This is an error message.");
        }
    }
}

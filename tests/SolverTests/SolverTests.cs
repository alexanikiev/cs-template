using SolverApp;
using Xunit;

namespace SolverTests
{
    public class SolverTests
    {
        [Fact]
        public void Solve_ReturnsExpectedProduct()
        {
            var solver = new Solver("a", "b");
            int result = solver.Solve(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Error_ThrowsException()
        {
            var solver = new Solver("a", "b");
            var ex = Assert.Throws<System.Exception>(() => solver.Error());
            Assert.Equal("This is an error message.", ex.Message);
        }
    }
}

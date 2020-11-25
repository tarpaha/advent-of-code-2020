using NUnit.Framework;

namespace day_2020_12_01.tests
{
    public class SolverTests
    {
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        public void Solver_Works_Correctly(int n, int result)
        {
            Assert.That(Solver.NumberOfOddNumbers(n), Is.EqualTo(result));
        }
    }
}
using NUnit.Framework;

namespace day_2020_12_18.tests
{
    public class SolverTests
    {
        [TestCase("1 + 2 * 3 + 4 * 5 + 6", "1 + (2 * 3) + (4 * (5 + 6))", "5 + (8 * 3 + 9 + 3 * 4 * 3)", 71 + 51 + 437)]
        public void Part1(string s1, string s2, string s3, int result)
        {
            Assert.That(Solver.Part1(new [] { s1, s2, s3 }), Is.EqualTo(result));
        }
    }
}
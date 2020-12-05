using NUnit.Framework;

namespace day_2020_12_05.tests
{
    public class SolverTests
    {
        [TestCase("BFFFBBFRRR", 567)]
        [TestCase("FFFBBBFRRR", 119)]
        [TestCase("BBFFBBFRLL", 820)]
        public void GetSeatId_Works_Correctly(string str, int result)
        {
            Assert.That(Solver.GetSeatId(str), Is.EqualTo(result));
        }
    }
}
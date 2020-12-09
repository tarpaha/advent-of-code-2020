using NUnit.Framework;

namespace day_2020_12_09.tests
{
    public class SolverTests
    {
        [TestCase(new long[] {1, 2, 3}, 0, 3, 1, false)]
        [TestCase(new long[] {1, 2, 3}, 0, 3, 2, false)]
        [TestCase(new long[] {1, 2, 3}, 0, 3, 3, true)]
        [TestCase(new long[] {1, 2, 3}, 0, 3, 4, true)]
        [TestCase(new long[] {1, 2, 3}, 0, 3, 5, true)]
        [TestCase(new long[] {1, 2, 3}, 0, 2, 3, true)]
        [TestCase(new long[] {1, 2, 3}, 1, 2, 3, false)]
        [TestCase(new long[] {1, 2, 3}, 1, 2, 5, true)]
        public void HaveTwoNumbersWithSum(long[] numbers, int offset, int len, long sum, bool result)
        {
            Assert.That(Solver.HaveTwoNumbersWithSum(numbers, offset, len, sum), Is.EqualTo(result));
        }
    }
}
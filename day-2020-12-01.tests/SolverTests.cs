using NUnit.Framework;

namespace day_2020_12_01.tests
{
    public class SolverTests
    {
        [TestCase(new [] { 1721, 979, 366, 299, 675, 1456 }, 514579)]
        public void Part1(int[] numbers, int result)
        {
            Assert.That(Solver.Part1(numbers), Is.EqualTo(result));
        }
        
        [TestCase(new [] { 1721, 979, 366, 299, 675, 1456 }, 241861950)]
        public void Part2(int[] numbers, int result)
        {
            Assert.That(Solver.Part2(numbers), Is.EqualTo(result));
        }
    }
}
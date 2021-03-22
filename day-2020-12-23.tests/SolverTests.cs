using NUnit.Framework;

namespace day_2020_12_23.tests
{
    public class SolverTests
    {
        [TestCase(389125467, 9, 10, 92658374)]
        [TestCase(389125467, 9, 100, 67384529)]
        public void Part1(int input, int max, int moves, int result)
        {
            Assert.That(Solver.Part1(input, max, moves), Is.EqualTo(result));
        }

        [TestCase(389125467, 1000000, 10000000, 149245887792)]
        public void Part2(int input, int max, int moves, long result)
        {
            Assert.That(Solver.Part2(input, max, moves), Is.EqualTo(result));
        }
    }
}
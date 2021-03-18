using NUnit.Framework;

namespace day_2020_12_23.tests
{
    public class SolverTests
    {
        [TestCase(389125467, 10, 92658374)]
        [TestCase(389125467, 100, 67384529)]
        public void Part1(int input, int moves, int result)
        {
            Assert.That(Solver.Part1(input, moves), Is.EqualTo(result));
        }

        [Test]
        public void Part2()
        {
            Assert.That(Solver.Part2(), Is.Null);
        }
    }
}
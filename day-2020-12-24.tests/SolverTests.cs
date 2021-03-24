using NUnit.Framework;

namespace day_2020_12_24.tests
{
    public class SolverTests
    {
        [Test]
        public void Part1()
        {
            Assert.That(Solver.Part1(), Is.Null);
        }

        [Test]
        public void Part2()
        {
            Assert.That(Solver.Part2(), Is.Null);
        }

        [TestCase(0, 0, "nwwswee", 0, 0)]
        [TestCase(0, 0, "nwswseenenwsw", 0, 0)]
        public void Move_Works_Correctly(int x1, int y1, string str, int x2, int y2)
        {
            var result = Solver.Move((x1, y1), Parser.Parse(str));
            Assert.That(result, Is.EqualTo((x2, y2)));
        }
    }
}
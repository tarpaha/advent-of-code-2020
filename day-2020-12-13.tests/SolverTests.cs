using NUnit.Framework;

namespace day_2020_12_13.tests
{
    public class SolverTests
    {
        [TestCase(@"939
7,13,x,x,59,x,31,19", 295)]
        public void Part1(string data, int result)
        {
            var (time, ids) = Parser.Parse(data);
            Assert.That(Solver.Part1(time, ids), Is.EqualTo(result));
        }
    }
}
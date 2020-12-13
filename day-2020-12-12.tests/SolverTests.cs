using NUnit.Framework;

namespace day_2020_12_12.tests
{
    public class SolverTests
    {
        [TestCase("F10,N3,F7,R90,F11", ",", 25)]
        public void Part1(string str, string separator, int result)
        {
            Assert.That(Solver.Part1(Parser.ParseInstructions(str, separator)), Is.EqualTo(result));
        }
    }
}
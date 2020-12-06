using NUnit.Framework;

namespace day_2020_12_06.tests
{
    public class SolverTests
    {
        [TestCase("abc||a|b|c||ab|ac||a|a|a|a||b", "|", 11)]
        public void Part1(string data, string newLine, int result)
        {
            var groups = Parser.ParseGroups(data, newLine);
            Assert.That(Solver.Part1(groups), Is.EqualTo(result));
        }
        
        [TestCase("abc||a|b|c||ab|ac||a|a|a|a||b", "|", 6)]
        public void Part2(string data, string newLine, int result)
        {
            var groups = Parser.ParseGroups(data, newLine);
            Assert.That(Solver.Part2(groups), Is.EqualTo(result));
        }
    }
}
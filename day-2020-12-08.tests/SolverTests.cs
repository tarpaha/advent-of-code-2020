using NUnit.Framework;

namespace day_2020_12_08.tests
{
    public class SolverTests
    {
        [TestCase(@"
nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6", 5)]
        public void Part1(string data, int result)
        {
            Assert.That(Solver.Part1(Parser.Parse(data)), Is.EqualTo(result));
        }

        [TestCase(@"
nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6", 8)]
        public void Part2(string data, int result)
        {
            Assert.That(Solver.Part2(Parser.Parse(data)), Is.EqualTo(result));
        }
    }
}
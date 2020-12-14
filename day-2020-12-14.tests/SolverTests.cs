using NUnit.Framework;

namespace day_2020_12_14.tests
{
    public class SolverTests
    {
        [TestCase(@"
mask = XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
mem[8] = 11
mem[7] = 101
mem[8] = 0", 165)]
        public void Part1(string data, long result)
        {
            Assert.That(Solver.Part1(Parser.ParseCommands(data)), Is.EqualTo(result));
        }
        
        [TestCase(@"
mask = 000000000000000000000000000000X1001X
mem[42] = 100
mask = 00000000000000000000000000000000X0XX
mem[26] = 1", 208)]
        public void Part2(string data, long result)
        {
            Assert.That(Solver.Part2(Parser.ParseCommands(data)), Is.EqualTo(result));
        }
    }
}
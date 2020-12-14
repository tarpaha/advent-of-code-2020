using System;
using System.Linq;
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
    }
}
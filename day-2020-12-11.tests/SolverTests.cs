using NUnit.Framework;

namespace day_2020_12_11.tests
{
    public class SolverTests
    {
        [TestCase(@"
L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL", 37)]
        public void Part1(string data, int result)
        {
            Assert.That(Solver.Part1(Parser.Parse(data)), Is.EqualTo(result));
        }
        
        [TestCase(@"
L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL", 26)]
        public void Part2(string data, int result)
        {
            Assert.That(Solver.Part2(Parser.Parse(data)), Is.EqualTo(result));
        }
        
    }
}
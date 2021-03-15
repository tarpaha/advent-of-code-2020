using NUnit.Framework;

namespace day_2020_12_22.tests
{
    public class SolverTests
    {
        [TestCase(@"
Player 1:
9
2
6
3
1

Player 2:
5
8
4
7
10", 306)]
        public void Part1(string data, int result)
        {
            Assert.That(Solver.Part1(Parser.Parse(data)), Is.EqualTo(result));
        }

        [TestCase(@"
Player 1:
43
19

Player 2:
2
29
14", 105)]
        [TestCase(@"
Player 1:
9
2
6
3
1

Player 2:
5
8
4
7
10", 291)]
        public void Part2(string data, int result)
        {
            Assert.That(Solver.Part2(Parser.Parse(data)), Is.EqualTo(result));
        }
        
    }
}
using NUnit.Framework;

namespace day_2020_12_19.tests
{
    public class SolverTests
    {
        [TestCase(@"0: 4 1 5
1: 2 3 | 3 2
2: 4 4 | 5 5
3: 4 5 | 5 4
4: ""a""
5: ""b""

ababbb
bababa
abbbab
aaabbb
aaaabbb", 2)]
        public void Part1(string data, int result)
        {
            Assert.That(Solver.Part1(Parser.Parse(data)), Is.EqualTo(result));
        }
        
        [TestCase("aab", true)]
        [TestCase("aba", true)]
        [TestCase("bba", false)]
        [TestCase("abb", false)]
        [TestCase("abaa", false)]
        public void IsMessageValid_Works_Correctly01(string message, bool result)
        {
            const string data = @"
0: 1 2
1: ""a""
2: 1 3 | 3 1
3: ""b"""; 
            var rules = RulesParser.Parse(data);
            Assert.That(Solver.IsMessageValid(rules[0], message), Is.EqualTo(result));
        }
        
        [TestCase("ababbb", true)]
        [TestCase("abbbab", true)]
        [TestCase("bababa", false)]
        [TestCase("aaabbb", false)]
        [TestCase("aaaabbb", false)]
        public void IsMessageValid_Works_Correctly02(string message, bool result)
        {
            const string data = @"
0: 4 1 5
1: 2 3 | 3 2
2: 4 4 | 5 5
3: 4 5 | 5 4
4: ""a""
5: ""b"""; 
            var rules = RulesParser.Parse(data);
            Assert.That(Solver.IsMessageValid(rules[0], message), Is.EqualTo(result));
        }
        
    }
}
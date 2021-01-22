using System.Linq;
using NUnit.Framework;

namespace day_2020_12_19.tests
{
    public class ParserTests
    {
        [Test]
        public void Parse_Works_Correctly()
        {
            const string data = @"0: 4 1 5
1: 2 3 | 3 2
2: 4 4 | 5 5
3: 4 5 | 5 4
4: ""a""
5: ""b""

ababbb
bababa
abbbab
aaabbb
aaaabbb";
            var (rules, messages) = Parser.Parse(data);
            Assert.That(rules.Count(), Is.EqualTo(6));
            Assert.That(messages.Count(), Is.EqualTo(5));
        }
        
    }
}
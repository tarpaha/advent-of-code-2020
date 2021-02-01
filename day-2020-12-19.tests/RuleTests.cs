using NUnit.Framework;

namespace day_2020_12_19.tests
{
    public class RuleTests
    {
        [Test]
        public void Length_Works_Correctly()
        {
            const string data = @"
0: 1 2
1: ""a""
2: 1 3 | 3 1
3: ""b"""; 
            var rules = RulesParser.Parse(data);
            Assert.That(rules[1].Length, Is.EqualTo(1));
            Assert.That(rules[3].Length, Is.EqualTo(1));
            Assert.That(rules[2].Length, Is.EqualTo(2));
            Assert.That(rules[0].Length, Is.EqualTo(3));
        }
    }
}
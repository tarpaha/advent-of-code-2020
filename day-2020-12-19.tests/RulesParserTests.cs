using day_2020_12_19.Rules;
using NUnit.Framework;

namespace day_2020_12_19.tests
{
    public class RulesParserTests
    {
        [Test]
        public void Parse_Works_Correctly()
        {
            const string data = @"
0: 1 2
1: ""a""
2: 1 3 | 3 1 3
3: ""b"""; 
            var rules = RulesParser.Parse(data);
            Assert.That(rules.Count, Is.EqualTo(4));
            Assert.That(rules[0], Is.TypeOf<Complex>());
            Assert.That(rules[1], Is.TypeOf<Simple>());
            Assert.That(rules[2], Is.TypeOf<Complex>());
            Assert.That(rules[3], Is.TypeOf<Simple>());
            
            Assert.That(rules[1].Length, Is.EqualTo(1));
            Assert.That(rules[3].Length, Is.EqualTo(1));
            Assert.That(rules[2].Length, Is.EqualTo(3));
            Assert.That(rules[0].Length, Is.EqualTo(4));
        }
    }
}
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_16.tests
{
    public class ParserTests
    {
        [Test]
        public void Parse_Works_Correctly()
        {
            const string data = @"
class: 1-3 or 5-7
row: 6-11 or 33-44
seat: 13-40 or 45-50

your ticket:
7,1,14

nearby tickets:
7,3,47
40,4,50
55,2,20
38,6,12";
            var problem = Parser.Parse(data);
            Assert.That(problem.Rules.Count(), Is.EqualTo(3));
            Assert.That(problem.YourTicket.Numbers, Is.EquivalentTo(new[] { 7, 1, 14 }));
            Assert.That(problem.NearbyTickets.Count(), Is.EqualTo(4));
        }
        
        [TestCase("departure location: 49-258 or 268-960", "departure location", 49, 258, 268, 960)]
        public void ParseRule_Works_Correctly(string str, string name, int r1min, int r1max, int r2min, int r2max)
        {
            var rule = Parser.ParseRule(str);
            Assert.That(rule.Name, Is.EqualTo(name));
            Assert.That(rule.Range1, Is.EqualTo((r1min, r1max)));
            Assert.That(rule.Range2, Is.EqualTo((r2min, r2max)));
        }

        [TestCase("7,3,47", new [] { 7, 3, 47 })]
        public void ParseTicket_Works_Correctly(string str, IEnumerable<int> numbers)
        {
            Assert.That(Parser.ParseTicket(str).Numbers, Is.EquivalentTo(numbers));
        }
    }
}
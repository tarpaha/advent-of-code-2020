using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace day_2020_12_07.tests
{
    public class ParserTests
    {
        private static IEnumerable<TestCaseData> ParseLineTestCases
        {
            get
            {
                yield return new TestCaseData(
                    "light red bags contain 1 bright white bag, 2 muted yellow bags.",
                    "light red", new [] { ("bright white", 1), ("muted yellow", 2) });
                yield return new TestCaseData(
                    "bright white bags contain 1 shiny gold bag.",
                    "bright white", new [] { ("shiny gold", 1) });
                yield return new TestCaseData(
                    "faded blue bags contain no other bags.",
                    "faded blue", Enumerable.Empty<(string, int)>());
            }
        }
        
        [TestCaseSource(nameof(ParseLineTestCases))]
        public void ParseLine_Works_Correctly(string line, string resultName, IEnumerable<(string, int)> resultBags)
        {
            var (name, bags) = Parser.ParseLine(line);
            Assert.That(name, Is.EqualTo(resultName));
            Assert.That(bags, Is.EquivalentTo(resultBags));
        }
    }
}
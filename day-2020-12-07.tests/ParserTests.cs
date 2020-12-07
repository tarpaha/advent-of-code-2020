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

        [Test]
        public void Parse_Works_Correctly()
        {
            var bags = Parser.Parse(@"
light red bags contain 1 bright white bag, 2 muted yellow bags
bright white bags contain 1 shiny gold bag.").ToList();
            
            Assert.That(bags.Count, Is.EqualTo(4));
            Assert.That(bags.Select(bag => bag.Name), Is.EquivalentTo(new [] { "light red", "bright white", "muted yellow", "shiny gold" }));

            var bagsDict = bags.ToDictionary(bag => bag.Name, bag => bag);
            var lightRed = bagsDict["light red"];
            var brightWhite = bagsDict["bright white"];
            var mutedYellow = bagsDict["muted yellow"];
            var shinyGold = bagsDict["shiny gold"];
            
            Assert.That(lightRed.InnerBags, Is.EquivalentTo(new [] { (brightWhite, 1), (mutedYellow, 2) }));
            Assert.That(lightRed.OuterBags.Count(), Is.Zero);

            Assert.That(mutedYellow.InnerBags.Count(), Is.Zero);
            Assert.That(mutedYellow.OuterBags, Is.EquivalentTo(new[] { lightRed }));
            
            Assert.That(brightWhite.InnerBags, Is.EquivalentTo(new [] { (shinyGold, 1) }));
            Assert.That(brightWhite.OuterBags, Is.EquivalentTo(new[] { lightRed }));
            
            Assert.That(shinyGold.InnerBags.Count(), Is.Zero);
            Assert.That(shinyGold.OuterBags, Is.EquivalentTo(new[] { brightWhite }));
        }
    }
}
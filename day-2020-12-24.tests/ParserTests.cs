using NUnit.Framework;

namespace day_2020_12_24.tests
{
    public class ParserTests
    {
        [TestCase("esenee", new[] { Direction.E, Direction.SE, Direction.NE, Direction.E })]
        public void Parse_Works_Correctly(string str, Direction[] result)
        {
            Assert.That(Parser.Parse(str), Is.EquivalentTo(result));
        }
    }
}
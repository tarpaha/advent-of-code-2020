using System.Linq;
using NUnit.Framework;

namespace day_2020_12_17.tests
{
    public class ParserTests
    {
        [TestCase(".#.|..#|###", "|", 5)]
        public void GetActiveCubesPositions_Works_Correctly(string str, string separator, int cubesCount)
        {
            Assert.That(Parser.GetActiveCubesPositions(str, separator).Count(), Is.EqualTo(cubesCount));
        }
    }
}
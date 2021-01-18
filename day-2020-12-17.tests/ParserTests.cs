using NUnit.Framework;

namespace day_2020_12_17.tests
{
    public class ParserTests
    {
        [TestCase(".#.|..#|###", "|", 5)]
        public void Parser_Works_Correctly(string str, string separator, int cubesCount)
        {
            Assert.That(Parser.Parse3D(str, separator).ActiveCubesCount, Is.EqualTo(cubesCount));
        }
    }
}
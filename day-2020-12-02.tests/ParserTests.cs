using FluentAssertions;
using NUnit.Framework;

namespace day_2020_12_02.tests
{
    public class ParserTests
    {
        [TestCase("1-3 a: abcde", 1, 3, 'a', "abcde")]
        [TestCase("1-3 b: cdefg", 1, 3, 'b', "cdefg")]
        [TestCase("2-9 c: ccccccccc", 2, 9, 'c', "ccccccccc")]
        public void Parse_Works_Correctly(string data, int min, int max, char ch, string password)
        {
            Parser.Parse(data).Should().BeEquivalentTo(new Record(min, max, ch, password));
        }
    }
}
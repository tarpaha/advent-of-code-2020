using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace day_2020_12_02.tests
{
    public class ParserTests
    {
        private static IEnumerable<TestCaseData> ParserTestCases
        {
            get
            {
                yield return new TestCaseData("1-3 a: abcde", new Record(1, 3, 'a', "abcde"));
                yield return new TestCaseData("1-3 b: cdefg", new Record(1, 3, 'b', "cdefg"));
                yield return new TestCaseData("2-9 c: ccccccccc", new Record(2, 9, 'c', "ccccccccc"));
            }
        }
        
        [TestCaseSource(nameof(ParserTestCases))]
        public void Parse_Works_Correctly(string s, Record result)
        {
            Parser.Parse(s).Should().BeEquivalentTo(result);
        }
    }
}
using System.Linq;
using NUnit.Framework;

namespace day_2020_12_06.tests
{
    public class ParserTests
    {
        [TestCase("abc", "|", 1, 3)]
        [TestCase("a|b|c", "|", 3, 1)]
        [TestCase("ab|ac", "|", 2, 2)]
        [TestCase("a|a|a|a", "|", 4, 1)]
        [TestCase("b", "|", 1, 1)]
        public void ParseGroup_Works_Correctly(string data, string newLine, int personsCount, int answersCount)
        {
            var persons = Parser.ParseGroup(data, newLine).ToList(); 
            Assert.That(persons.Count, Is.EqualTo(personsCount));
            Assert.That(persons.First().Length, Is.EqualTo(answersCount));
        }

        [TestCase("abc||a|b|c||ab|ac||a|a|a|a||b", "|", 5)]
        public void ParseGroups_Works_Correctly(string data, string newLine, int groupsCount)
        {
            Assert.That(Parser.ParseGroups(data, newLine).Count(), Is.EqualTo(groupsCount));
        }
    }
}
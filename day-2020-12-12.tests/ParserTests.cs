using NUnit.Framework;

namespace day_2020_12_12.tests
{
    public class ParserTests
    {
        [TestCase("F10", Action.F, 10)]
        [TestCase("N3", Action.N, 3)]
        [TestCase("F7", Action.F, 7)]
        [TestCase("R90", Action.R, 90)]
        [TestCase("F11", Action.F, 11)]
        public void ParseAction_Works_Correctly(string str, Action actionResult, int valueResult)
        {
            var (action, value) = Parser.ParseAction(str);
            Assert.That(action, Is.EqualTo(actionResult));
            Assert.That(value, Is.EqualTo(valueResult));
        }
    }
}
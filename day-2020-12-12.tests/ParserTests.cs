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
        public void ParseInstruction_Works_Correctly(string str, Action instructionAction, int instructionValue)
        {
            var instruction = Parser.ParseInstruction(str);
            Assert.That(instruction.Action, Is.EqualTo(instructionAction));
            Assert.That(instruction.Value, Is.EqualTo(instructionValue));
        }
    }
}
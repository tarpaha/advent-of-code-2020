using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace day_2020_12_08.tests
{
    public class ParserTests
    {
        [TestCase("nop +0", Operation.nop, 0)]
        [TestCase("acc +1", Operation.acc, 1)]
        [TestCase("jmp -3", Operation.jmp, -3)]
        public void ParseLine_Works_Correctly(string line, Operation operation, int argument)
        {
            var instruction = Parser.ParseLine(line);
            Assert.That(instruction.Operation, Is.EqualTo(operation));
            Assert.That(instruction.Argument, Is.EqualTo(argument));
        }

        [TestCase(@"
nop +0
acc +1
jmp -3",
            new [] { Operation.nop, Operation.acc, Operation.jmp},
            new [] { 0, 1, -3})]
        public void Parse_Works_Correctly(string lines, Operation[] operations, int [] arguments)
        {
            var instructions = Parser.Parse(lines).ToList();
            Assert.That(instructions.Select(instruction => instruction.Operation), Is.EquivalentTo(operations));
            Assert.That(instructions.Select(instruction => instruction.Argument), Is.EquivalentTo(arguments));
        }
    }
}
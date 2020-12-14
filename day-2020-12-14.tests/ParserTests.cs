using NUnit.Framework;

namespace day_2020_12_14.tests
{
    public class ParserTests
    {
        [TestCase("mask = XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X")]
        public void ParseCommand_ParsesSetMask_Correctly(string str, string mask)
        {
            var command = Parser.ParseCommand(str) as SetMask;
            Assert.That(command, Is.Not.Null);
            Assert.That(command.Mask, Is.EqualTo(mask));
        }
        
        [TestCase("mem[8] = 11", 8, 11)]
        [TestCase("mem[7] = 101", 7, 101)]
        [TestCase("mem[8] = 0", 8, 0)]
        public void ParseCommand_ParsesWriteToMemory_Correctly(string str, long address, long value)
        {
            var command = Parser.ParseCommand(str) as WriteToMemory;
            Assert.That(command, Is.Not.Null);
            Assert.That(command.Address, Is.EqualTo(address));
            Assert.That(command.Value, Is.EqualTo(value));
        }
    }
}
using NUnit.Framework;

namespace day_2020_12_12.tests
{
    public class Ship2Tests
    {
        [TestCase("F10,N3,F7,R90,F11", ",", 286)]
        public void ExecuteInstructions_Works_Correctly(string str, string separator, int result)
        {
            var ship = new Ship2();
            ship.ExecuteInstructions(Parser.ParseInstructions(str, separator));
            Assert.That(ship.ManhattanDistance, Is.EqualTo(result));
        }
        
        [TestCase("F5", 55)]
        public void ExecuteInstruction_Works_Correctly(string str, int result)
        {
            var ship = new Ship2();
            ship.ExecuteInstruction(Parser.ParseInstruction(str));
            Assert.That(ship.ManhattanDistance, Is.EqualTo(result));
        }
    }
}
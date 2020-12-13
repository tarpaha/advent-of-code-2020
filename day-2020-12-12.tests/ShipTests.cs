using NUnit.Framework;

namespace day_2020_12_12.tests
{
    public class ShipTests
    {
        [TestCase("F10,N3,F7,R90,F11", ",", 25)]
        public void ExecuteInstructions_Works_Correctly(string str, string separator, int result)
        {
            var ship = new Ship();
            ship.ExecuteInstructions(Parser.ParseInstructions(str, separator));
            Assert.That(ship.ManhattanDistance, Is.EqualTo(result));
        }
        
        [TestCase("F5", 5)]
        [TestCase("N3", 3)]
        [TestCase("R90", 0)]
        [TestCase("L90", 0)]
        public void ExecuteInstruction_Works_Correctly(string str, int result)
        {
            var ship = new Ship();
            ship.ExecuteInstruction(Parser.ParseInstruction(str));
            Assert.That(ship.ManhattanDistance, Is.EqualTo(result));
        }
    }
}
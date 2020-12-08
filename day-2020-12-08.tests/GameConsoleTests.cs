using NUnit.Framework;

namespace day_2020_12_08.tests
{
    public class GameConsoleTests
    {
        [TestCase(@"
nop +0
acc +2
nop +0
acc -1", 1)]
        [TestCase(@"
jmp +2
jmp +3
jmp -1
jmp -99
acc +3
", 3)]
        public void Program_Executes_Correctly(string lines, int result)
        {
            var gameConsole = new GameConsole();
            gameConsole.LoadProgram(Parser.Parse(lines));
            gameConsole.Start();
            Assert.That(gameConsole.Accumulator, Is.EqualTo(result));
        }
    }
}
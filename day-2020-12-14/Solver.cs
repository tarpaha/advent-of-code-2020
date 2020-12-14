using System.Collections.Generic;

namespace day_2020_12_14
{
    public static class Solver
    {
        public static long Part1(IEnumerable<Command> commands)
        {
            var computer = new Computer();
            computer.ProcessCommands(commands);
            return computer.GetSumOfValuesInMemory();
        }
    }
}
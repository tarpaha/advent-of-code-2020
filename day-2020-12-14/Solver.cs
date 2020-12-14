using System.Collections.Generic;

namespace day_2020_12_14
{
    public static class Solver
    {
        public static long Part1(IEnumerable<Command> commands)
        {
            var computer = new Computer1();
            computer.ProcessCommands(commands);
            return computer.GetSumOfValuesInMemory();
        }

        public static long Part2(IEnumerable<Command> commands)
        {
            var computer = new Computer2();
            computer.ProcessCommands(commands);
            return computer.GetSumOfValuesInMemory();
        }
    }
}
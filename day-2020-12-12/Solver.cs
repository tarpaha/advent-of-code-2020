using System.Collections.Generic;

namespace day_2020_12_12
{
    public class Solver
    {
        public static int Part1(IEnumerable<Instruction> instructions)
        {
            var ship = new Ship();
            ship.ExecuteInstructions(instructions);
            return ship.ManhattanDistance;
        }
    }
}
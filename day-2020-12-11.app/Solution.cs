using System;
using utils;

namespace day_2020_12_11.app
{
    public class Solution : ISolution
    {
        private readonly Cell[,] _cells;
        
        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _cells = Parser.Parse(Input.GetData());
        }

        public object SolvePart1()
        {
            return Solver.Part1(_cells);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}
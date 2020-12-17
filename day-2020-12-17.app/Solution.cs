using System;
using utils;

namespace day_2020_12_17.app
{
    public class Solution : ISolution
    {
        private readonly Grid _grid;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _grid = Parser.Parse(Input.GetData(), Environment.NewLine);
        }

        public object SolvePart1()
        {
            return Solver.Part1(_grid, 6);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}
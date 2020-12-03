using System;
using utils;

namespace day_2020_12_03.app
{
    public class Solution : ISolution
    {
        private readonly bool[,] _cells;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _cells = Parser.Parse(Input.GetData(), Environment.NewLine);
        }

        public object SolvePart1()
        {
            return Solver.TreesCount(_cells, 3, 1);
        }

        public object SolvePart2()
        {
            return
                Solver.TreesCount(_cells, 1, 1) *
                Solver.TreesCount(_cells, 3, 1) *
                Solver.TreesCount(_cells, 5, 1) *
                Solver.TreesCount(_cells, 7, 1) *
                Solver.TreesCount(_cells, 1, 2);
        }
    }
}
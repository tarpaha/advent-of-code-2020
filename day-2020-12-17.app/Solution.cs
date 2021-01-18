using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_17.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<(int x, int y)> _activeCubes;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _activeCubes = Parser.GetActiveCubesPositions(Input.GetData(), Environment.NewLine);
        }

        public object SolvePart1()
        {
            return Solver.Part1(new Grid3D(_activeCubes), 6);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}
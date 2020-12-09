using System;
using utils;
using System.Linq;

namespace day_2020_12_09.app
{
    public class Solution : ISolution
    {
        private readonly long[] _numbers;
        
        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _numbers = Input.GetData().ToArray();
        }
        
        public object SolvePart1()
        {
            return Solver.Part1(_numbers, 25);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}
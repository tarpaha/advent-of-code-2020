using System;
using System.Linq;
using System.Collections.Generic;
using utils;

namespace day_2020_12_04.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<IPassword> _passports;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _passports = Parser.ParsePassports(Input.GetData());
        }

        public object SolvePart1()
        {
            return _passports.Count(p => p.IsValid);
        }

        public object SolvePart2()
        {
            return default;
        }
    }
}
using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_14.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<Command> _commands;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _commands = Parser.ParseCommands(Input.GetData());
        }

        public object SolvePart1()
        {
            return Solver.Part1(_commands);
        }

        public object SolvePart2()
        {
            return Solver.Part2(_commands);;
        }
    }
}
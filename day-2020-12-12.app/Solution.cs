﻿using System;
using System.Collections.Generic;
using utils;

namespace day_2020_12_12.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<Instruction> _instructions;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _instructions = Parser.ParseInstructions(Input.GetData(), Environment.NewLine);
        }

        public object SolvePart1()
        {
            return Solver.Part1(_instructions);
        }

        public object SolvePart2()
        {
            return Solver.Part2(_instructions);
        }
    }
}
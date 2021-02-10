﻿using System;
using System.Linq;
using System.Collections.Generic;
using utils;

namespace day_2020_12_20.app
{
    public class Solution : ISolution
    {
        private readonly IEnumerable<Tile> _tiles;

        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _tiles = Parser.ParseTiles(Input.GetData()).ToList();
        }

        public object SolvePart1()
        {
            return Solver.Part1(_tiles);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}
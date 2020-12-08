using System;
using utils;

namespace day_2020_12_08.app
{
    public class Solution : ISolution
    {
        private readonly GameConsole _gameConsole;
        
        public static void Main()
        {
            var solution = new Solution();
            Console.WriteLine($"Part1: {solution.SolvePart1()}");
            Console.WriteLine($"Part2: {solution.SolvePart2()}");
        }

        public Solution()
        {
            _gameConsole = new GameConsole();
            _gameConsole.LoadProgram(Parser.Parse(Input.GetData()));
        }

        public object SolvePart1()
        {
            return Solver.Part1(_gameConsole);
        }

        public object SolvePart2()
        {
            return null;
        }
    }
}
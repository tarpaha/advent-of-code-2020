using System;
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_08
{
    public static class Solver
    {
        public static int Part1(IEnumerable<Instruction> instructions)
        {
            var gameConsole = new GameConsole();
            gameConsole.LoadProgram(instructions);
            gameConsole.Start();
            return gameConsole.Accumulator;
        }

        public static int Part2(IEnumerable<Instruction> instructions)
        {
            var program = instructions.ToArray();
            
            var gameConsole = new GameConsole();
            gameConsole.LoadProgram(program);
            gameConsole.Start();

            var visitedPointers = gameConsole.VisitedPointers.ToList();
            
            foreach (var visitedPointer in visitedPointers)
            {
                var instruction = program[visitedPointer];
                switch (instruction.Operation)
                {
                    case Operation.jmp:
                        program[visitedPointer] = new Instruction(Operation.nop, instruction.Argument);
                        gameConsole.LoadProgram(program);
                        gameConsole.Start();
                        if (!gameConsole.InfiniteLoop)
                            return gameConsole.Accumulator;
                        program[visitedPointer] = new Instruction(Operation.jmp, instruction.Argument);
                        break;
                    case Operation.nop:
                        program[visitedPointer] = new Instruction(Operation.jmp, instruction.Argument);
                        gameConsole.LoadProgram(program);
                        gameConsole.Start();
                        if (!gameConsole.InfiniteLoop)
                            return gameConsole.Accumulator;
                        program[visitedPointer] = new Instruction(Operation.nop, instruction.Argument);
                        break;
                }
            }

            throw new Exception();
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_08
{
    public class GameConsole
    {
        public int Accumulator => _accumulator;
        public IEnumerable<int> VisitedPointers => _visitedPointers;
        public bool InfiniteLoop => _infiniteLoopFlag;

        public void LoadProgram(IEnumerable<Instruction> instructions)
        {
            _program = instructions.ToArray();
        }

        public void Start()
        {
            _instructionPointer = 0;
            _accumulator = 0;

            _infiniteLoopFlag = false;
            _visitedPointers.Clear();

            while (_instructionPointer < _program.Length)
            {
                if (_visitedPointers.Contains(_instructionPointer))
                {
                    _infiniteLoopFlag = true;
                    break;
                }

                _visitedPointers.Add(_instructionPointer);

                var instruction = _program[_instructionPointer];
                switch (instruction.Operation)
                {
                    case Operation.nop:
                        break;
                    case Operation.acc:
                        _accumulator += instruction.Argument;
                        break;
                    case Operation.jmp:
                        _instructionPointer += instruction.Argument - 1;
                        break;
                    default:
                        throw new Exception();
                }

                _instructionPointer += 1;
            }
        }
        
        private Instruction[] _program;
        
        private int _instructionPointer;
        private int _accumulator;

        private bool _infiniteLoopFlag;
        private readonly HashSet<int> _visitedPointers = new HashSet<int>();
    }
}
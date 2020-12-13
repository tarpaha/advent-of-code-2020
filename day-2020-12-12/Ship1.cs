using System;
using System.Collections.Generic;

namespace day_2020_12_12
{
    public class Ship1
    {
        private int _x;
        private int _y;
        private int _angle;

        public int ManhattanDistance => Math.Abs(_x) + Math.Abs(_y); 
    
        public void ExecuteInstructions(IEnumerable<Instruction> instructions)
        {
            foreach (var instruction in instructions)
                ExecuteInstruction(instruction);
        }
        
        public void ExecuteInstruction(Instruction instruction)
        {
            switch (instruction.Action)
            {
                case Action.N:
                    _y += instruction.Value;
                    break;
                case Action.S:
                    _y -= instruction.Value;
                    break;
                case Action.E:
                    _x += instruction.Value;
                    break;
                case Action.W:
                    _x -= instruction.Value;
                    break;
                case Action.L:
                    _angle += instruction.Value;
                    if (_angle >= 360)
                        _angle -= 360;
                    break;
                case Action.R:
                    _angle -= instruction.Value;
                    if (_angle < 0)
                        _angle += 360;
                    break;
                case Action.F:
                    switch (_angle)
                    {
                        case 0:
                            _x += instruction.Value;
                            break;
                        case 90:
                            _y += instruction.Value;
                            break;
                        case 180:
                            _x -= instruction.Value;
                            break;
                        case 270:
                            _y -= instruction.Value;
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
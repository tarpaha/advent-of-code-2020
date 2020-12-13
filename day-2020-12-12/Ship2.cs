using System;
using System.Collections.Generic;

namespace day_2020_12_12
{
    public class Ship2
    {
        private int _x;
        private int _y;

        private int _waypointX;
        private int _waypointY;

        public int ManhattanDistance => Math.Abs(_x) + Math.Abs(_y);

        public Ship2()
        {
            _waypointX = 10;
            _waypointY = 1;
        }

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
                    _waypointY += instruction.Value;
                    break;
                case Action.S:
                    _waypointY -= instruction.Value;
                    break;
                case Action.E:
                    _waypointX += instruction.Value;
                    break;
                case Action.W:
                    _waypointX -= instruction.Value;
                    break;
                case Action.L:
                    switch (instruction.Value)
                    {
                        case 90:
                            (_waypointX, _waypointY) = (-_waypointY, _waypointX);
                            break;
                        case 180:
                            (_waypointX, _waypointY) = (-_waypointX, -_waypointY);
                            break;
                        case 270:
                            (_waypointX, _waypointY) = (_waypointY, -_waypointX);
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                case Action.R:
                    switch (instruction.Value)
                    {
                        case 90:
                            (_waypointX, _waypointY) = (_waypointY, -_waypointX);
                            break;
                        case 180:
                            (_waypointX, _waypointY) = (-_waypointX, -_waypointY);
                            break;
                        case 270:
                            (_waypointX, _waypointY) = (-_waypointY, _waypointX);
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                case Action.F:
                    _x += instruction.Value * _waypointX;
                    _y += instruction.Value * _waypointY; 
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
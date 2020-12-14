using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_14
{
    public class Computer
    {
        private string _mask;
        private readonly Dictionary<long, long> _memory = new Dictionary<long, long>();

        public void ProcessCommands(IEnumerable<Command> commands)
        {
            foreach (var command in commands)
            {
                ProcessCommand(command);
            }
        }

        public long GetSumOfValuesInMemory()
        {
            return _memory.Values.Sum();
        }

        private void ProcessCommand(Command command)
        {
            switch (command)
            {
                case SetMask cmd:
                    SetMask(cmd.Mask);
                    break;
                case WriteToMemory cmd:
                    WriteToMemory(cmd.Address, cmd.Value);
                    break;
            }
        }

        private void SetMask(string mask)
        {
            _mask = mask;
        }

        private void WriteToMemory(long address, long value)
        {
            _memory[address] = ApplyMask(value, _mask);
        }
        
        public static long ApplyMask(long number, string mask)
        {
            long bit = 1;
            for (var i = mask.Length - 1; i >= 0; i--, bit <<= 1)
            {
                switch (mask[i])
                {
                    case '0':
                        number &= ~bit;
                        break;
                    case '1':
                        number |= bit;
                        break;
                }
            }
            return number;
        }
    }
}
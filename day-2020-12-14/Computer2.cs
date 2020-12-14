using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace day_2020_12_14
{
    public class Computer2
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
            var addressTemplate = DecimalToBinary36(address);
            for (var i = 0; i < addressTemplate.Length; i++)
            {
                if (_mask[i] != '0')
                    addressTemplate[i] = _mask[i];
            }
            
            var addresses = ExpandTemplate(addressTemplate.ToString());
            foreach (var addr in addresses)
            {
                _memory[addr] = value;
            }
        }

        public static StringBuilder DecimalToBinary36(long value)
        {
            var binary = new StringBuilder(new string('0', 36));
            var index = 35;
            while (value > 0)
            {
                if ((value & 1) != 0)
                    binary[index] = '1';
                value >>= 1;
                index -= 1;
            }
            return binary;
        }

        public static IEnumerable<long> ExpandTemplate(string addressTemplate)
        {
            var addresses = new List<string> {addressTemplate};
            for (var i = 0; i < addresses.Count; i++)
            { 
                var xPos = addresses[i].IndexOf('X');
                if (xPos < 0)
                    continue;

                var address = new StringBuilder(addresses[i]);

                address[xPos] = '0';
                addresses[i] = address.ToString();
                
                address[xPos] = '1';
                addresses.Add(address.ToString());

                i -= 1;
            }
            return addresses.Select(m => Convert.ToInt64(m, 2));
        }
    }
}
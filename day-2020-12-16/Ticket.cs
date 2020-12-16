using System.Collections.Generic;

namespace day_2020_12_16
{
    public class Ticket
    {
        public IEnumerable<int> Numbers { get; }

        public Ticket(IEnumerable<int> numbers)
        {
            Numbers = numbers;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_02
{
    public static class Solver
    {
        public static int Part1(IEnumerable<Record> records)
        {
            return records
                .Count(PasswordIsValidPart1);
        }

        public static int Part2(IEnumerable<Record> records)
        {
            return records
                .Count(PasswordIsValidPart2);
        }
        
        public static bool PasswordIsValidPart1(Record record)
        {
            var count = 0;
            foreach (var ch in record.Password)
            {
                if (ch == record.Char)
                    count += 1;
                if (count > record.Max)
                    return false;
            }
            return count >= record.Min;
        }
        
        public static bool PasswordIsValidPart2(Record record)
        {
            var p1 = record.Password[record.Min - 1] == record.Char;
            var p2 = record.Password[record.Max - 1] == record.Char;
            return p1 ^ p2;
        }
    }
}
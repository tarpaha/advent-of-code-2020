using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_02
{
    public static class Solver
    {
        public static int Part1(IEnumerable<Record> records)
        {
            return records
                .AsParallel()
                .Count(PasswordIsValid);
        }

        public static bool PasswordIsValid(Record record)
        {
            var count = record
                .Password
                .GroupBy(ch => ch)
                .FirstOrDefault(group => group.Key == record.Char)
                ?.Count();
            
            return count.HasValue && record.Min <= count && count <= record.Max;
        }
    }
}
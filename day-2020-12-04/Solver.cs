using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_04
{
    public static class Solver
    {
        public static int Part1(IEnumerable<Passport> passports)
        {
            return passports.Count(p => p.IsValidPart1);
        }
        
        public static int Part2(IEnumerable<Passport> passports)
        {
            return passports.Count(p => p.IsValidPart2);
        }
    }
}
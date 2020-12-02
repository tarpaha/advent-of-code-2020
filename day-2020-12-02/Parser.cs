using System;

namespace day_2020_12_02
{
    public static class Parser
    {
        public static Record Parse(string s)
        {
            var parts = s.Split(new [] {'-', ':', ' '}, StringSplitOptions.RemoveEmptyEntries);
            return new Record(
                int.Parse(parts[0]),
                int.Parse(parts[1]),
                parts[2][0],
                parts[3]);
        }
    }
}
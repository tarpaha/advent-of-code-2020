using System;
using System.Collections.Generic;

namespace day_2020_12_07
{
    public static class Parser
    {
        public static (string name, IEnumerable<(string, int)> bags) ParseLine(string line)
        {
            var words = line.Split(new[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
            var name = $"{words[0]} {words[1]}";

            var bags = new List<(string, int)>();
            
            if (words.Length > 7)
            {
                for (var p = 4; p < words.Length; p += 4)
                {
                    bags.Add(($"{words[p+1]} {words[p+2]}", int.Parse(words[p])));
                }
            }
            
            return (name, bags);
        }
    }
}
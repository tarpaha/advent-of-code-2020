using System;
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_04
{
    public static class Parser
    {
        public static IEnumerable<Passport> ParsePassports(string data)
        {
            var blocks = data.Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries);
            return blocks.Select(ParsePassport).ToList();
        }
        
        public static Passport ParsePassport(string data)
        {
            var pairs = data.Split(new [] { Environment.NewLine, " " }, StringSplitOptions.RemoveEmptyEntries);
            var dict = pairs.Select(pair => pair.Split(':')).ToDictionary(e => e[0], e => e[1]);
            return new Passport(dict);
        }
    }
}
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

        public static IEnumerable<Bag> Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, Bag>();

            foreach (var line in lines)
            {
                var (name, innerBags) = ParseLine(line);
                var bag = GetBagOrCreateNew(dict, name);
                foreach (var (innerName, innerCount) in innerBags)
                {
                    var nestedBag = GetBagOrCreateNew(dict, innerName);
                    bag.AddInnerBag(nestedBag, innerCount);
                }
            }

            return dict.Values;
        }

        private static Bag GetBagOrCreateNew(Dictionary<string, Bag> bags, string name)
        {
            bags.TryGetValue(name, out var bag);
            if (bag == null)
            {
                bag = new Bag(name);
                bags.Add(name, bag);
            }
            return bag;
        }
    }
}
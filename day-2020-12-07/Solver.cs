using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_07
{
    public static class Solver
    {
        private const string TargetBagName = "shiny gold";
        
        public static int Part1(IEnumerable<Bag> bags)
        {
            var names = new HashSet<string>();
            var outerBags = new List<Bag>(bags.First(b => b.Name == TargetBagName).OuterBags);
            for (var i = 0; i < outerBags.Count; i++)
            {
                var outerBag = outerBags[i];
                if (!names.Contains(outerBag.Name))
                {
                    names.Add(outerBag.Name);
                    outerBags.AddRange(outerBag.OuterBags);
                }
            }
            return names.Count;
        }
    }
}
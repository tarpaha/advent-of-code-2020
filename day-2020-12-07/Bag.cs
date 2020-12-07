using System.Collections.Generic;

namespace day_2020_12_07
{
    public class Bag
    {
        public string Name { get; }
        public IEnumerable<Bag> OuterBags => _outerBags;
        public IEnumerable<(Bag, int)> InnerBags => _innerBags;

        public Bag(string name)
        {
            Name = name;
        }

        public void AddInnerBag(Bag bag, in int count)
        {
            _innerBags.Add((bag, count));
            bag._outerBags.Add(this);
        }
        
        private readonly List<Bag> _outerBags = new List<Bag>();
        private readonly List<(Bag, int)> _innerBags = new List<(Bag, int)>();
    }
}
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_23
{
    public class CircleList
    {
        public CircleList(IEnumerable<int> numbers)
        {
            _list = new List<CircleListNode>(numbers.Select(number => new CircleListNode(number)));
            for (var i = 0; i < _list.Count - 1; i++)
                _list[i].Next = _list[i + 1];
            _list[^1].Next = _list[0];
        }

        public CircleListNode First => _list[0];
        
        private readonly List<CircleListNode> _list;

        public CircleListNode TakeAfter(CircleListNode node)
        {
            var taken = node.Next;
            _list.Remove(taken);
            node.Next = taken.Next;
            return taken;
        }

        public CircleListNode Find(int number)
        {
            return _list.First(n => n.Number == number);
        }

        public void PlaceAfter(CircleListNode node, IEnumerable<CircleListNode> nodes)
        {
            var nodesToAdd = nodes.ToList();
            _list.InsertRange(_list.IndexOf(node) + 1, nodesToAdd);
            for (var i = 0; i < nodesToAdd.Count - 1; i++)
            {
                nodesToAdd[i].Next = nodesToAdd[i + 1];
            }
            nodesToAdd[^1].Next = node.Next;
            node.Next = nodesToAdd[0];
        }
        
        public override string ToString()
        {
            return $"{string.Join(",", _list)}";
        }

        public IEnumerable<int> ToListStartingFrom(CircleListNode node)
        {
            var result = new List<int>();
            for (var i = 0; i < _list.Count; i++)
            {
                result.Add(node.Number);
                node = node.Next;
            }
            return result;
        }
    }
}
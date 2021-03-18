using System.Linq;

namespace day_2020_12_23
{
    public static class Solver
    {
        public static int Part1(int input, int moves)
        {
            var cups = new CircleList(input.ToString().Select(ch => ch - '0'));
            var current = cups.First;

            for (var i = 0; i < moves; i++)
            {
                var takenCups = new[]
                {
                    cups.TakeAfter(current),
                    cups.TakeAfter(current),
                    cups.TakeAfter(current),
                };
                var takenNumbers = takenCups.Select(n => n.Number).ToHashSet();

                var destinationNumber = current.Number;
                while (true)
                {
                    destinationNumber -= 1;
                    if (destinationNumber <= 0)
                        destinationNumber = 9;
                    if (!takenNumbers.Contains(destinationNumber))
                        break;
                }

                var destinationCup = cups.Find(destinationNumber);
                cups.PlaceAfter(destinationCup, takenCups);

                current = current.Next;
            }

            return int.Parse(string.Join("", cups.ToListStartingFrom(cups.Find(1)).Skip(1)));
        }
        
        public static object Part2()
        {
            return null;
        }
    }
}
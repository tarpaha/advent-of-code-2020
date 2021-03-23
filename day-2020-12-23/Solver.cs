using System.Linq;

namespace day_2020_12_23
{
    public static class Solver
    {
        public static int Part1(int input, int max, int moves)
        {
            var cups = Iterate(input, max, moves);
            var cup = cups[1]; 
            cup = cup.Next;

            var result = "";
            for (var i = 1; i < max; i++)
            {
                result += cup.Number.ToString();
                cup = cup.Next;
            }

            return int.Parse(result);
        }
        
        public static long Part2(int input, int max, int moves)
        {
            var cups = Iterate(input, max, moves);
            var cup = cups[1];
            return (long)cup.Next.Number * cup.Next.Next.Number;
        }

        private static Cup[] Iterate(int input, int max, int moves)
        {
            var (cups, current) = CreateCups(input, max);
            for (var i = 0; i < moves; i++)
            {
                var taken = current.Next;
                var n1 = taken.Number;
                var n2 = taken.Next.Number;
                var n3 = taken.Next.Next.Number;
            
                current.Next = taken.Next.Next.Next;

                var destination = current.Number;
                while (true)
                {
                    destination -= 1;
                    if (destination <= 0)
                        destination = max;
                    if (destination != n1 && destination != n2 && destination != n3)
                        break;
                }

                var destinationCup = cups[destination];
                var nextAfterDestination = destinationCup.Next;

                destinationCup.Next = taken;
                taken.Next.Next.Next = nextAfterDestination;

                current = current.Next;
            }
            return cups;
        }

        private static (Cup[], Cup) CreateCups(int input, int max)
        {
            var numbers = input.ToString().Select(ch => ch - '0').ToList();
            var cups = new Cup[max + 1];
            
            var firstCup = new Cup(numbers[0]);
            cups[numbers[0]] = firstCup;
            
            var currentCup = firstCup;
            
            for (var i = 1; i < 9; i++)
            {
                var newCup = new Cup(numbers[i]);
                cups[numbers[i]] = newCup;
                
                currentCup.Next = newCup;
                currentCup = newCup;
            }
            
            for (var i = 10; i <= max; i++)
            {
                var newCup = new Cup(i);
                cups[i] = newCup;
                
                currentCup.Next = newCup;
                currentCup = newCup;
            }
            
            currentCup.Next = firstCup;
            
            return (cups, firstCup);
        }
    }
}
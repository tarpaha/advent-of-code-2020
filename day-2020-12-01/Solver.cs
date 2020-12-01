using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_01
{
    public static class Solver
    {
        private const int Year = 2020;
        
        public static int Part1(IEnumerable<int> numbers)
        {
            var (_, n1, n2) = GetTwoNumbersWithSum(numbers, Year);
            return n1 * n2;
        }

        public static int Part2(IEnumerable<int> numbers)
        {
            var (n1, n2, n3) = GetThreeNumbersWithSum(numbers, Year);
            return n1 * n2 * n3;
        }
        
        private static (bool, int, int) GetTwoNumbersWithSum(IEnumerable<int> numbers, int sum)
        {
            var residuals = new HashSet<int>();
            foreach (var number in numbers)
            {
                if (residuals.Contains(number))
                    return (true, number, sum - number);
                residuals.Add(sum - number);
            }
            return (false, 0, 0);
        }

        private static (int, int, int) GetThreeNumbersWithSum(IEnumerable<int> numbers, int sum)
        {
            var numbersList = numbers.ToList(); 
            for (var i = 0; i < numbersList.Count; i++)
            {
                var number = numbersList[i];
                var (found, n1, n2) = GetTwoNumbersWithSum(numbersList.Skip(i), sum - number);
                if (found)
                    return (number, n1, n2);
            }
            throw new Exception();
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_06
{
    public static class Solver
    {
        public static int Part1(IEnumerable<IEnumerable<string>> groups)
        {
            return groups.Sum(group => group.SelectMany(ch => ch).Distinct().Count());
        }
        
        public static int Part2(IEnumerable<IEnumerable<string>> groups)
        {
            return groups.Sum(GetGroupSimilarAnswers);
        }

        private static int GetGroupSimilarAnswers(IEnumerable<string> answersCollection)
        {
            var answers = answersCollection.ToList();
            var collector = new Dictionary<char, int>();
            foreach (var ch in answers.SelectMany(answer => answer))
            {
                collector.TryGetValue(ch, out var count);
                collector[ch] = count + 1;
            }
            return collector.Values.Count(v => v == answers.Count);
        }
    }
}
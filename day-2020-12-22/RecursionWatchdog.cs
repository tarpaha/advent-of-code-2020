using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_22
{
    public class RecursionWatchdog
    {
        private readonly HashSet<(int, int)> _roundHashes = new();
        
        public void AddRound(IEnumerable<int> player1Cards, IEnumerable<int> player2Cards)
        {
            _roundHashes.Add((GetHash(player1Cards), GetHash(player2Cards)));
        }

        public bool IsAlreadyPlayedRound(IEnumerable<int> player1Cards, IEnumerable<int> player2Cards)
        {
            var roundHash = (GetHash(player1Cards), GetHash(player2Cards));
            return _roundHashes.Contains(roundHash);
        }

        private static int GetHash(IEnumerable<int> collection)
        {
            // https://stackoverflow.com/a/3404820/2220552
            return collection.Aggregate(1, (current, value) => unchecked(current * 71 + value));
        }
    }
}
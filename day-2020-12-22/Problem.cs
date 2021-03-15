using System.Collections.Generic;

namespace day_2020_12_22
{
    public class Problem
    {
        public IEnumerable<int> Player1Cards { get; }
        public IEnumerable<int> Player2Cards { get; }

        public Problem(IEnumerable<int> player1Cards, IEnumerable<int> player2Cards)
        {
            Player1Cards = new List<int>(player1Cards);
            Player2Cards = new List<int>(player2Cards);
        }
    }
}
using System.Collections.Generic;

namespace day_2020_12_22
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            var player1Cards = new Queue<int>(problem.Player1Cards);
            var player2Cards = new Queue<int>(problem.Player2Cards);

            while (player1Cards.Count > 0 && player2Cards.Count > 0)
            {
                var player1Card = player1Cards.Dequeue();
                var player2Card = player2Cards.Dequeue();
                if (player1Card > player2Card)
                {
                    player1Cards.Enqueue(player1Card);
                    player1Cards.Enqueue(player2Card);
                }
                else
                {
                    player2Cards.Enqueue(player2Card);
                    player2Cards.Enqueue(player1Card);
                }
            }

            var winnerDeck = player1Cards.Count > 0 ? player1Cards : player2Cards;

            var result = 0;
            for (var multiplier = winnerDeck.Count; multiplier > 0; multiplier--)
            {
                result += multiplier * winnerDeck.Dequeue();
            }

            return result;
        }
    }
}
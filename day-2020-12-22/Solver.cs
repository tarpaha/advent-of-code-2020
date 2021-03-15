using System.Collections.Generic;
using System.Linq;

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
            return GetScore(winnerDeck);
        }

        public static int Part2(Problem problem)
        {
            var player1Cards = new Queue<int>(problem.Player1Cards);
            var player2Cards = new Queue<int>(problem.Player2Cards);

            var recursionWatchdog = new RecursionWatchdog();
            var player1WonBecauseOfRecursion = PlaySubGame(player1Cards, player2Cards);
            
            var winnerDeck = player1Cards.Count > 0 || player1WonBecauseOfRecursion ? player1Cards : player2Cards;
            return GetScore(winnerDeck);
        }

        private static bool PlaySubGame(Queue<int> player1Cards, Queue<int> player2Cards)
        {
            var recursionWatchdog = new RecursionWatchdog();
            while (player1Cards.Count > 0 && player2Cards.Count > 0)
            {
                if (recursionWatchdog.IsAlreadyPlayedRound(player1Cards, player2Cards))
                    return true;

                recursionWatchdog.AddRound(player1Cards, player2Cards);
                
                var player1Card = player1Cards.Dequeue();
                var player2Card = player2Cards.Dequeue();

                if (player1Card <= player1Cards.Count && player2Card <= player2Cards.Count)
                {
                    var subGamePlayer1Cards = new Queue<int>(player1Cards.ToList().Take(player1Card));
                    var subGamePlayer2Cards = new Queue<int>(player2Cards.ToList().Take(player2Card));
                    
                    var player1WonBecauseOfRecursion = PlaySubGame(subGamePlayer1Cards, subGamePlayer2Cards);
                    
                    if (subGamePlayer1Cards.Count > 0 || player1WonBecauseOfRecursion)
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
                else
                {
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
            }
            return false;
        }

        private static int GetScore(IEnumerable<int> cards)
        {
            var result = 0;
            var cardsList = cards.ToList();
            var multiplier = cardsList.Count;
            foreach (var card in cardsList)
            {
                result += multiplier * card;
                multiplier -= 1;
            }
            return result;
        }
    }
}
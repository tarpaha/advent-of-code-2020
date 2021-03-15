using System;
using NUnit.Framework;

namespace day_2020_12_22.tests
{
    public class ParserTests
    {
        [Test]
        public void Parser_Works_Correctly()
        {
            var player1Cards = new[] {1, 2, 3};
            var player2Cards = new[] {4, 5, 6, 7};
            var player1CardLines = string.Join(Environment.NewLine, player1Cards);
            var player2CardLines = string.Join(Environment.NewLine, player2Cards);
            var data = string.Join(Environment.NewLine,
                new [] {
                    "Player 1:",
                    player1CardLines,
                    "",
                    "Player 2:",
                    player2CardLines
                });

            var problem = Parser.Parse(data);
            Assert.That(problem.Player1Cards, Is.EquivalentTo(player1Cards));
            Assert.That(problem.Player2Cards, Is.EquivalentTo(player2Cards));
        }
    }
}
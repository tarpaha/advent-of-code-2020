using System;
using System.Linq;

namespace day_2020_12_22
{
    public static class Parser
    {
        public static Problem Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var player2Index = Array.IndexOf(lines, "Player 2:");
            var player1Lines = lines[1..player2Index];
            var player2Lines = lines[(player2Index + 1)..];
            return new Problem(player1Lines.Select(int.Parse), player2Lines.Select(int.Parse));
        }
    }
}
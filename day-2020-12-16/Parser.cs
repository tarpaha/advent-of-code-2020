using System;
using System.Linq;

namespace day_2020_12_16
{
    public static class Parser
    {
        private const string YourTicketLabel = "your ticket:";
        private const string NearbyTicketsLabel = "nearby tickets:";
        
        public static Problem Parse(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            
            var yourTicketLabelIndex = Array.FindIndex(lines, line => line == YourTicketLabel);

            var rules = lines[..yourTicketLabelIndex].Select(ParseRule);
            var yourTicket = ParseTicket(lines[yourTicketLabelIndex + 1]);
            
            var nearbyTicketsLabelIndex = Array.FindIndex(lines, line => line == NearbyTicketsLabel);
            var nearbyTickets = lines[(nearbyTicketsLabelIndex + 1)..].Select(ParseTicket);

            return new Problem(rules, yourTicket, nearbyTickets);
        }

        public static Rule ParseRule(string str)
        {
            var nameAndRanges = str.Split(':');
            var ranges = nameAndRanges[1].Split(new[] {" ", "-", "or"}, StringSplitOptions.RemoveEmptyEntries);
            return new Rule(
                nameAndRanges[0],
                (int.Parse(ranges[0]), int.Parse(ranges[1])),
                (int.Parse(ranges[2]), int.Parse(ranges[3]))
            );
        }

        public static Ticket ParseTicket(string str)
        {
            return new Ticket(str.Split(',').Select(int.Parse));
        }
    }
}
using System.Collections.Generic;

namespace day_2020_12_16
{
    public class Problem
    {
        public IEnumerable<Rule> Rules { get; }
        public Ticket YourTicket { get; }
        public IEnumerable<Ticket> NearbyTickets { get; }

        public Problem(IEnumerable<Rule> rules, Ticket yourTicket, IEnumerable<Ticket> nearbyTickets)
        {
            Rules = rules;
            YourTicket = yourTicket;
            NearbyTickets = nearbyTickets;
        }
    }
}
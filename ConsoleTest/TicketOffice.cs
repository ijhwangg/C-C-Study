using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    public class TicketOffice
    {
        private double amount;
        private List<Ticket> tickets = new List<Ticket>();

        public TicketOffice(double amount, IEnumerable<Ticket> tickets)
        {
            this.amount = amount;
            this.tickets.AddRange(tickets);
        }

        public Ticket GetTicket()
        {
            var firstTicket = tickets[0];
            tickets.RemoveAt(0);
            return firstTicket;
        }

        public void minusAmount(double amount)
        {
            this.amount -= amount;
        }

        public void plusAmount(double amount)
        {
            this.amount += amount;
        }
    }
}


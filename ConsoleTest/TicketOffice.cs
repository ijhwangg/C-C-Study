using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpStudy
{
    public class TicketOffice
    {
        private long amount;
        private List<Ticket> tickets = new List<Ticket>();
       
        public void sellTicketTo(Audience audience)
        {
            plusAmount(audience.buy(GetTicket()));
        }

        private Ticket GetTicket()
        {
            var firstTicket = tickets[0];
            tickets.RemoveAt(0);
            return firstTicket;
        }

        private void plusAmount(long amount)
        {
            this.amount += amount;
        }
    }
}


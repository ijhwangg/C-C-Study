using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpStudy
{
    public class Bag
    {
        private Invitation invitation;
        private long amount;
        private Ticket ticket;

        public long Hold(Ticket ticket)
        {
            if (hasInvitation())
            {
                setTicket(ticket);
                return 0L;
            }
            else
            {
                setTicket(ticket);
                minusAmount(ticket.getFee());
                return ticket.getFee();
            }
        }

        private bool hasInvitation()
        {
            return invitation != null;
        }

        private void setTicket(Ticket ticket)
        {
            this.ticket = ticket;
        }

        private void minusAmount(long amount)
        {
            this.amount -= amount;
        }
    }
}

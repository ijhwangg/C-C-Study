using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    public class Theater
    {
        public TicketSeller ticketSeller;

        public Theater(TicketSeller ticketSeller)
        {
            this.ticketSeller = ticketSeller;
        }

        public void enter(Audience audience)
        {
            if (audience.GetBag().hasInvitation())
            {
                Ticket ticket = ticketSeller.GetTicketOffice().GetTicket();
                audience.GetBag().setTicket(ticket);
            }
            else
            {
                Ticket ticket = ticketSeller.GetTicketOffice().GetTicket();
                audience.GetBag().minusAmount(ticket.getFee());
                ticketSeller.GetTicketOffice().plusAmount(ticket.getFee());
                audience.GetBag().setTicket(ticket);
            }
        }
    }
}

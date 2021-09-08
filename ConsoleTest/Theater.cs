using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpStudy
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
            ticketSeller.sellTo(audience);
        }
    }
}

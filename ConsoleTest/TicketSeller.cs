using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    public class TicketSeller
    {
        private TicketOffice ticketOffice;

        public TicketSeller(TicketOffice ticketOffice)
        {
            this.ticketOffice = ticketOffice;
        }

        public TicketOffice GetTicketOffice()
        {
            return ticketOffice;
        }
    }
}

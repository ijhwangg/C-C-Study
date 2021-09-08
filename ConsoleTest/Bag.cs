using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    public class Bag
    {
        private Invitation invitation;
        private double amount;
        private Ticket ticket;
        public Bag(double amount)
        {
            this.invitation = null;
            this.amount = amount;
        }
        public Bag(Invitation invitation, double amount)
        {
            this.invitation = invitation;
            this.amount = amount;
        }

        public bool hasTicket()
        {
            return ticket != null;
        }

        public bool hasInvitation()
        {
            return invitation != null;
        }

        public void setTicket(Ticket ticket)
        {
            this.ticket = ticket;
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

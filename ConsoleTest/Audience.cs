using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpStudy
{
    public class Audience
    {
        private Bag bag;

        public Audience(Bag bag)
        {
            this.bag = bag;
        }

        public long buy(Ticket ticket)
        {
            return bag.Hold(ticket);
        }
    }
}

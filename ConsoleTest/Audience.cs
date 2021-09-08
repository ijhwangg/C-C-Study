using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    public class Audience
    {
        private Bag bag;

        public Audience(Bag bag)
        {
            this.bag = bag;
        }

        public Bag GetBag()
        {
            return bag;
        }
    }
}

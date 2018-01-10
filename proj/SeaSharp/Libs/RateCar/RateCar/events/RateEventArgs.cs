using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCar.events
{
    public class RateEventArgs : EventArgs
    {
        private readonly string test;

        public RateEventArgs(string test)
        {
            this.test = test;
        }

        public string Test
        {
            get { return this.test; }
        }
    }
}

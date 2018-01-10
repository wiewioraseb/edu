using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCar.events
{
    public class RateEventArgs : EventArgs
    {
        private readonly int id;
        private readonly string model;

        public RateEventArgs(int id, string model)
        {
            this.id = id;
            this.model = model;
        }

        public int Id{ get { return this.id; }}
        public string Model { get { return this.model; }}

    }
}

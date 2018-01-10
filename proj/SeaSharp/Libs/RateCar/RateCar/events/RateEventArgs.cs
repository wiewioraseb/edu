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
        private readonly string brand;
        private readonly string model;


        public RateEventArgs(int id,string brand, string model)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
        }

        public int Id { get { return this.id; }}
        public string Brand { get { return this.brand; } }
        public string Model { get { return this.model; }}

    }
}

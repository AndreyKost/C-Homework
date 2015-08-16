using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Automobile:Car
    {
        private float theFuelConsumption;
        private int p1;
        private double p2;

        public float TheFuelConsumption
        {
            get { return theFuelConsumption; }
            set { theFuelConsumption = value; }
        }

       

        public Automobile(int price, float theFuelConsumption)
            : base(price)
        {
            this.theFuelConsumption = theFuelConsumption;
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    class Celzii
    {
        private double gradusi;
        public double Gradusi
        {
            get { return gradusi; }
            set { gradusi = value; }
        }

        public Celzii()
        {
        }
        public void Konvertirane(double celzii, double farenheit)
        {
            farenheit = (celzii * 9) / 5 + 32;
            Console.WriteLine("{0}°C v Farenheit e  {1}°F", celzii, farenheit);
        }
    }
}

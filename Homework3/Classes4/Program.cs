using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedete temperatura v Celzii za da se preobrazuva v Farenheit ");
            double c = double.Parse(Console.ReadLine());
            double f = 0;
            Console.WriteLine();
            Celzii gradusi = new Celzii();
            gradusi.Gradusi = c;
            gradusi.Konvertirane(c, f);
            Console.WriteLine();
        }
    }
}

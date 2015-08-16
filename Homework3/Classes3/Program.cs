using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedete katet a za pravougulen triugulnik : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("vuvedete katet b za pravougulen triugulnik : ");
            double b = double.Parse(Console.ReadLine());

            Triangle pravougulen = new Triangle(a,b);

            pravougulen.A = a;
            pravougulen.B = b;
            pravougulen.Hipotenuza(a, b);
            pravougulen.Ugli(a, b);
            Console.WriteLine();
        }
    }
}

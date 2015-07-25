using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideTwoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete edno realno chislo a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete edno cqlo chislo b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Delenieto na a i b e = " + (double)(a/b));
        }
    }
}

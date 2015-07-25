using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete cqlo chislo a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete cqlo chislo b");
            int b = int.Parse(Console.ReadLine());
            int gcd=1;
            if (a>0 && b>0)
            {
                for (int i = Math.Min(a, b); i > 0; i--)
                {
                    if (a%i==0 && b%i==0)
                    {
                        gcd = i;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Trqbva a>0 i b>0 ! ");
            }
            Console.WriteLine("Nai-golemiqt obsht delite na chislata a i b e : "+gcd);
        }
    }
}

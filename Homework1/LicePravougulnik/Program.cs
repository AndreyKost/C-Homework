using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicePravougulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete edno cqlo chislo za strana a na pravogugulnik");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete vtoro cqlo chislo za strana b na pravouhulnik");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Liceto na pravogulnika e " + (a*b));
        }
    }
}

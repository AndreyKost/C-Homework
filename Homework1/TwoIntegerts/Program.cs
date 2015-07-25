using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegerts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete edno cqlo chislo a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete vtoro cqlo chislo b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ostatuka ot delenieto na a i  b e =" + (a%b));
        }
    }
}

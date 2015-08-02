using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value for c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("value for d");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("value for e ");
            int e = int.Parse(Console.ReadLine());
            int max1;
            max1 = Math.Max(c, d);

            MaxNumber(max1,e);
        }

        private static void MaxNumber(int a,int b)
        {
            Console.WriteLine( "Max element is : "+Math.Max(a, b));
        }
    }
}

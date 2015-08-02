using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            long result = Fibonachi(n);
            Console.WriteLine("fibonachi({0})={1}",n,result);

        }

        private static long Fibonachi(int n)
        {
            if (n<=2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}

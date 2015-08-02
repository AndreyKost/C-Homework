using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int val1 = rand.Next(1,100);
            int val2 = rand.Next(1,100);
            int val3 = rand.Next(1,100);
            Console.WriteLine("val1="+val1);
            Console.WriteLine("val2="+val2);
            Console.WriteLine("val3="+val3);
            Proizvedenie(val1,val2,val3);
        }

        private static void Proizvedenie(int a,int b,int c)
        {
            int sum = 0;
            sum = a + b + c;
            Console.WriteLine("sum is = "+sum);
        }
    }
}

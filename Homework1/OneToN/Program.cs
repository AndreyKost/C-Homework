using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete cqlo chislo n ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if(i%7!=0 && i%3!=0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}

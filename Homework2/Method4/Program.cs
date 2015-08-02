using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an integer number");
            int value1 = int.Parse(Console.ReadLine());
            CheckEven(value1);
            Console.WriteLine("enter another integer number");
            int value2 = int.Parse(Console.ReadLine());
            CheckEven(value2);
            Console.WriteLine("enter another integer number");
            int value3 = int.Parse(Console.ReadLine());
            CheckEven(value3);


        }

        private static void CheckEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("the number is even"); 
            }
            else
            {
                Console.WriteLine("the number is not even");
            }
        }
    }
}

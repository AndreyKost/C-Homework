using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete ime ");
            string name1=Console.ReadLine();
            PrintName(name1);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Greetings, "+name+"!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete nqkakuf string");
            string str1 = Console.ReadLine();
            bool equal = (str1 == "Hello World");
            Console.WriteLine("str1=Hello World-"+equal);
        }
    }
}

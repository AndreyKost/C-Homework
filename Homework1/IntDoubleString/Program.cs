using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete 0 za int");
            Console.WriteLine("vuvedete 1 za double");
            Console.WriteLine("vuvedete 2 za string");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    int i = int.Parse(Console.ReadLine());
                    i = i + 1;
                    Console.WriteLine(i); break;
                case 1:
                    double d = double.Parse(Console.ReadLine());
                    d = d + 1;
                    Console.WriteLine(d); break;
                case 2:
                    string s = Console.ReadLine();
                    Console.WriteLine(s + "*"); break;
                default: ; break;
            }
        }
    }
}

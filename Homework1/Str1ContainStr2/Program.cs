using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str1ContainStr2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool b=str1.Contains(str2);
            Console.WriteLine("Sudurja li se str2 v str1 ? : "+b);
        }
    }
}

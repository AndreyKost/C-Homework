using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings1
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete duma ");
            string myString = Console.ReadLine();
            Console.WriteLine("dumata naobratno");
            Console.WriteLine(Reverse(myString));
            

        }
    }
}

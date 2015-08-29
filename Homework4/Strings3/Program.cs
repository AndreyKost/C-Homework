using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete nqkakva duma ");
            
            string word= Console.ReadLine();
            Console.WriteLine("vuvedete nqkakvo izrechenie sudurjashto predhodnata duma ");
            string text = Console.ReadLine();

            Console.WriteLine("broq na sreshtaniq na dumata e  "+Occurences.CountStringOccurrences(text, word));



        }
    }
}

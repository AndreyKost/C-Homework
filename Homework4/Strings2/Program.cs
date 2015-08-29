using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete nqkakva duma");
            string word = Console.ReadLine();
            Console.WriteLine("vuvedete izrechenie sudurjashto predhodnata duma");
            string text = Console.ReadLine();
            string name = text.Replace(word,word.ToUpper());
            Console.WriteLine(name);

        }
    }
}

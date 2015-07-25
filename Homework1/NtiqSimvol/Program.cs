using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtiqSimvol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete nqkakuv niz ot simvoli");
            string s = Console.ReadLine();
            Console.WriteLine("goleminata na niza e ot 0 do n-1 ");
            Console.WriteLine("vuvedete chislo ot 0 do n-1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("N-tiq simvol ot string s e : "+s[n]);
        }
    }
}

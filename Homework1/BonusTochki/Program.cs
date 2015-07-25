using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusTochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete tochki ot 1 do 9");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    a+= 5;
                    Console.WriteLine(a);
                    break;
                case 4:
                case 5:
                case 6:
                    a *= 12;
                    Console.WriteLine(a);
                    break;
                case 7:
                case 8:
                case 9:
                    a = (a*50)/3;
                    Console.WriteLine(a);
                    break;
                default: Console.WriteLine(" vuvedete chislo ot 1 do 9");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete cifra ot 2 do 14");
            Console.WriteLine("Ot 2 do 10 otgovorqt ot 2ka do 10ka");
            Console.WriteLine("Na 11 otgovarq J Vale");
            Console.WriteLine("Na 12 otgovarq Q Dama");
            Console.WriteLine("Na 13 otgovarq K Pop");
            Console.WriteLine("Na 14 otgovarq A Asak");
            int a =int.Parse(Console.ReadLine());

            switch (a)
            {
                case 2: Console.WriteLine("validna karta"); break;
                case 3: Console.WriteLine("validna karta"); break;
                case 4: Console.WriteLine("validna karta"); break;
                case 5: Console.WriteLine("validna karta"); break;
                case 6: Console.WriteLine("validna karta"); break;
                case 7: Console.WriteLine("validna karta"); break;
                case 8: Console.WriteLine("validna karta"); break;
                case 9: Console.WriteLine("validna karta"); break;
                case 10: Console.WriteLine("validna karta"); break;
                case 11: Console.WriteLine("validna karta J"); break;
                case 12: Console.WriteLine("validna karta Q"); break;
                case 13: Console.WriteLine("validna karta K"); break;
                case 14: Console.WriteLine("validna karta A"); break;




                default: Console.WriteLine("Nevalidna karta !");
                    break;
            }
            
        }
    }
}

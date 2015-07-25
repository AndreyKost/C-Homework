using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Vuvedete chislo za N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete chislo za K");
            int K = int.Parse(Console.ReadLine());
            //Za da se nameri rezultata ot N!/K! trqbva da se izchisli proizvedenieto na chislata-
            //ot K+1 do N
            if (K >= N || N <= 1 || K <= 1 || N > 10000)
            {
                Console.WriteLine("Nevalidna stoinost ! ");
            }
            else
            {
                BigInteger rezultat = 1;
                for (int i = K + 1; i <= N; i++)
                {
                    rezultat *= i;
                }
                Console.WriteLine(rezultat);
            }

        }
    }
}

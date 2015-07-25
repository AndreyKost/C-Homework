using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialDiv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete stoinost za N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete stoinost za K");
            int K = int.Parse(Console.ReadLine());
            //Izpolzvam for cikul ot N-K+1 do N,chrez koito se izchislqva N!(N-K)!
            //Posle se pravi vtori cikul ot 2 do K izchislqvaiki K!
            if (K >= N || N <= 1 || K <= 1 || N > 100000)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            BigInteger factorial1 = 1;
            for (int i = N; i > (N - K); i--)
            {
                factorial1 *= i;
            }
            BigInteger factorial2 = 1;
            for (int m = K; m > 1; m--)
            {
                factorial2 *= m;
            }
            BigInteger rezultat = factorial1 * factorial2;
            Console.WriteLine(rezultat);

        }
    }
}

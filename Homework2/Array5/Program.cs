using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("duljina na masiv1");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine("duljina na masiv 2");
            int length2 = int.Parse(Console.ReadLine());
            if (length1 != length2)
            {
                Console.WriteLine("ne sa ednakvi");
                return;
            }
            int[] arr1 = new int[length1];
            int[] arr2 = new int[length2];
            Console.WriteLine("stoinosti na masiv1 ");
            for (int i = 0; i < length1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("stoinosti na masiv2");
            for (int i = 0; i < length2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length1; i++)
            {
                if (arr2[i] != arr1[i])
                {
                    Console.WriteLine("ne sa ednkvi ");
                }
            }
            Console.WriteLine(" ednakvi sa ");
        }
    }
}

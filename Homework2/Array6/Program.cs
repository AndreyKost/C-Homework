using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvuedete broi elementi na masiva");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("vuvedete stoinosti na masiva");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int count = 1;
            int maxCOunt = 1;
            int maxNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
                {
                    count++;
                    if (count > maxCOunt)
                    {
                        maxCOunt = count;
                        maxNumber = array[i - 1];

                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine("chisloto e= " + maxNumber + " i se sreshta " + count + "puti");
        }
    }
}

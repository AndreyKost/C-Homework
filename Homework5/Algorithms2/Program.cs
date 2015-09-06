using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            int[] array = new int[n];
            Random rand = new Random();


            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, n);
            }
            Console.WriteLine();
            // Print the unsorted array
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            //Sort the array
            BubbleSort(array);
            // Print the sorted array
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
        static void BubbleSort(int[] intArray)
        {

            for (int i = intArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int highValue = intArray[j];

                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = highValue;
                    }
                }
            }

            
        }
    }
}

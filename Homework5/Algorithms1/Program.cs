using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms1
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

            // Sort the array
            BucketSort(array);

            // Print the sorted array
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
        static void BucketSort(int[] integers)
        {
            
            if (integers == null || integers.Length == 0)
                return;
           
            int maxValue = integers[0]; 
            int minValue = integers[0];
           
            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] > maxValue)
                    maxValue = integers[i];
                if (integers[i] < minValue)
                    minValue = integers[i];
            }
            //Create a temporary "bucket" to store the values in order
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            
            for (int i = 0; i < integers.Length; i++)
            {
                bucket[integers[i] - minValue].Add(integers[i]);
            }
            //Move items in the bucket back to the original array in order
            int k = 0; 
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        integers[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion2
{
    class Program
    {
        static void Permutations(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                foreach (int value in arr)
                {
                    Console.Write(value);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    Permutations(arr, index + 1);
                    temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert number for n ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            Permutations(array, 0);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] occurense;
            int[] numbers = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            occurense = FindOccurence(numbers);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < occurense.Length; i++)
            {
                if (occurense[i] != 0)
                {
                    output.Append(i + " -> " + occurense[i] + " puti\n");
                }
            }

            Console.Write(output);
        }

        static int[] FindOccurence(int[] arr)
        {
            int[] occurenseCount = new int[1001];

            for (int i = 0; i < arr.Length; i++)
            {
                occurenseCount[arr[i]]++;
            }

            return occurenseCount;

        }
    }
}

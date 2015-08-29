using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Structure4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int>();
            string line;
            do
            {
                line = Console.ReadLine();
                if (line != "")
                {
                    inputNumbers.Add(int.Parse(line));
                }
            } while (line != "");
            inputNumbers.Sort();
            int majorant = int.MinValue;
            int count = 1;
            int tempIndex = 0;
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                majorant = inputNumbers[i];
                for (int j = i + 1; j < inputNumbers.Count; j++)
                {
                    tempIndex = j;
                    if (inputNumbers[i] == inputNumbers[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count >= inputNumbers.Count / 2 + 1)
                {
                    Console.WriteLine("The majorant is {0}.", majorant);
                    break;
                }
                if (i > inputNumbers.Count / 2 + 1)
                {
                    Console.WriteLine("The majorant doesn`t exist!");
                    break;
                }
                count = 1;
                i = tempIndex;
            }
        }
    }
}

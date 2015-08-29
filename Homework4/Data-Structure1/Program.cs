using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
        List<int> numbers = new List<int>();
        line = Console.ReadLine();
        while (line != "")
        {
            int number = int.Parse(line);
            numbers.Add(number);
            line = Console.ReadLine();
        }
            if (numbers.Count == 0)
            {
                Console.WriteLine("Ne se sudurja elementi");
            }
            else
            {
                Console.WriteLine(numbers.Sum());
                Console.WriteLine(numbers.Average());
            }
    }

        }
    }



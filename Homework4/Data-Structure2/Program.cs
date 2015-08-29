using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string line = Console.ReadLine();
            while (line != "")
            {
                int number = int.Parse(line);
                numbers.Add(number);
                line = Console.ReadLine();
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("Ne sudurja elementi");
            }
            else
            {
                foreach (double number in numbers)
                {
                    if (number >= 0)
                    {
                        Console.WriteLine(number);
                    }
                }
            }

        }
    }
}

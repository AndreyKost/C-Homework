using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert integer for value1");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insert integer for value2");
            int val2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insert integer for value3");
            int val3 = int.Parse(Console.ReadLine());
            Console.WriteLine("insert integer for value4");
            int val4 = int.Parse(Console.ReadLine());
            Console.WriteLine("insert integer for value5");
            int val5 = int.Parse(Console.ReadLine());
            int max1 = Math.Max(val1, val2);
            int max2 = Math.Max(val3, val4);
            max1 = Math.Max(max1, max2);
             max1 = Math.Max(max1, val5);
            Console.WriteLine("max="+max1);
            int min1 = Math.Min(val1, val2);
            int min2 = Math.Min(val3, val4);
             min1 = Math.Min(min1, min2);
             min1 = Math.Min(min1, val5);
            Console.WriteLine("min="+min1);

        }
    }
}

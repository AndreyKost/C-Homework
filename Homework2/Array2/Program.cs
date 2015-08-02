using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10];
        
            array[0] = 0;
            array[1] = 1;
            for (int i = 0; i < array.Length-2; i++)
            {
                array[i + 2] = array[i] + array[i + 1];
                Console.WriteLine(array[i+2]);
            }
   
        }
    }
}

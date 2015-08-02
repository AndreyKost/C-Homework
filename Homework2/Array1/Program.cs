using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] array=new int[n];
            for(int i=0;i<n;i++)
            {
              array[i]=int.Parse(Console.ReadLine());
            }
             int sum=0;
             for (int i = 0; i < n; i++)
             {
                 if (array[i] % 2 == 0)
                 {
                     sum += array[i];
                 }
             }
            Console.WriteLine("Sumata Na chetnite elementi na masiva sa= "+sum);

        }
    }
}

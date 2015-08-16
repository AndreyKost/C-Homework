using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] koli = new Car[5];
            for (int i = 0; i < koli.Length; i++)
            {
                koli[i] = new Car(345);
               
            }
            foreach (var item in koli)
            {
                Console.WriteLine(item);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Nicole",20);
            myCat.PrintSay();
            Console.WriteLine(new string('-', 40));
            Cat[] cats = new Cat[10];
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = new Cat("Cat" + Sequence.NextValue(),20);
            }
            foreach (var cat in cats)
            {
                cat.PrintSay();
            }



        }
    }
}

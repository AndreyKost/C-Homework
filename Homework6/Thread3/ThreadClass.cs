using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread3
{
    class ThreadClass 
    {
        public void DoTask1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1:job({0})", i);
                Thread.Sleep(50);
                if (i==50)
                {
                    Thread.Sleep(7500);
                }
            }
        }

        public void DoTask2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" Running");
                Thread.Sleep(500);
            }
        }
       
    }
}

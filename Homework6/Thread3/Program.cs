﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started.");

            ThreadClass threadClass = new ThreadClass();

            Thread thread1 = new Thread(
               new ThreadStart(threadClass.DoTask1));

            Thread thread2 = new Thread(
               new ThreadStart(threadClass.DoTask2));

            thread1.Start();
            thread2.Start();
            //thread1.Join();
            Console.WriteLine("Main thread finished.");
        }
    }
}

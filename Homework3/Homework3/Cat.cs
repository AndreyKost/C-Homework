using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Cat
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public Cat(string name,int year)
        {
             this.name = name;
             this.year = year;
        }
        public void PrintSay()
        {
            Console.WriteLine("the years of the cat are : "+year+ " and the name is : "+name);
        }

    }
}

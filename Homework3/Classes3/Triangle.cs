using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Triangle
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Triangle(double A, double B)
        {
            this.a = A;
            this.b = B;
        }
        public void Hipotenuza(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);
        }
        public void Ugli(double A, double B)
        {
            double c = Math.Sqrt(a * a + b * b);

            double angl1 = Math.Atan(a / b) * (180 / Math.PI);
            double angl2 = Math.Atan(a / b) * (180 / Math.PI);
            angl1 = Math.Asin(a / c) * (180 / Math.PI);
            angl2 = Math.Asin(b / c) * (180 / Math.PI);

            int angle1 = Convert.ToInt32(angl1);
            int angle2 = Convert.ToInt32(angl2);
            Console.WriteLine("dvata ugula sa : "+angle1+ " i : "+angle2+"gradusa");
        }
    }
}

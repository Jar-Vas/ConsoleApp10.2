using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Circle : IShape
    {
        public double R {  get; set; }

        public double CalculateArea()
        {
            return 3.14159265 * R * R;  
        }

        public double CalculatePerimeter()
        {
            return 2 * 3.14159265 * R;
        }
    }

    public class Rectangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }

        public double CalculateArea()
        {
            return A*B;
        }

        public double CalculatePerimeter()
        {
            return 2 * (A + B);
        }
    }

    public class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        public double CalculatePerimeter()
        {
            return A+B+C;
        }
    }
}

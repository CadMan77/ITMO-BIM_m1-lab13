using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab13
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Triangle TR1 = new Triangle(1,2,3);
            RectangularTriangle TR2 = new RectangularTriangle(3,4);*/
            RegularTriangle RgTr = new RegularTriangle(5);
            Triangle Tr = RgTr;
            if (Tr is RectangularTriangle)
            {
                RectangularTriangle RcTr = (RectangularTriangle)Tr;
            }
            Console.ReadKey();
        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetArea(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
    }
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(a * a + b * b);
        }
    }
    class RegularTriangle : Triangle
    {
        public RegularTriangle(double a)
        {
            A = a;
            B = a;
            C = a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Two_dimensional_Point_class
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter x =  ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Enter y =  ");
            double pointY = double.Parse(Console.ReadLine());
            Console.Write("Enter a =  ");
            double pointA = double.Parse(Console.ReadLine());
            Console.Write("Enter b =  ");
            double pointB = double.Parse(Console.ReadLine());
            Point pX = new Point(pointX, pointY);
            Point pY = new Point(pointA, pointB);
            Console.WriteLine("Distance: {0:F2}", Point.Distance(pX, pY));

            Console.ReadLine();
        }
    }
}

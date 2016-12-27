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

    class Point
    {
        double x;
        double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                if(value >= 0)
                {
                    this.x = value;
                }
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value >= 0)
                {
                    this.y = value;
                }
            }
        }
        public static double Distance(Point a, Point b)
        {
            double distanceX = a.x - b.x;
            double distanceY = a.y - b.y;
            return Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
        }
    }
}

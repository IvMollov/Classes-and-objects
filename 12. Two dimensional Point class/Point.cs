using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Two_dimensional_Point_class
{
   public class Point
    {
       private double x;
       private double y;

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
                this.x = value;
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
                this.y = value;
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

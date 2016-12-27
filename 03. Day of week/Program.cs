using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Today is {0:dddd}", now);

            Console.ReadLine();
        }
    }
}

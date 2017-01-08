using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01.Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 != 0)
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("{0} is a leap year.", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year.", year);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
            }

            Console.WriteLine("\nIs {0} a leap year? {1}", year, DateTime.IsLeapYear(year));

            Console.ReadLine();
        }

    }

}

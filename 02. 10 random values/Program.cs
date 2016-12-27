using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._10_random_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numbers = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (i == 10 - 1)
                {
                    Console.Write("{0}", numbers.Next(100, 200));
                }
                else
                {
                    Console.Write("{0}, ", numbers.Next(100, 200));
                }
            }
            Console.ReadLine();
        }
    }
}

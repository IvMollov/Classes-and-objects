using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Positive_integer
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input sequence of positive integers separated by spaces: ");
            string numbers = Console.ReadLine();

            int sum = SumFromString(numbers);
            Console.Write("Sum of positive integers is: {0}", sum);

            Console.ReadLine();
        }

        public static int SumFromString(string numbers)
        {

            int sum = 0;
            string[] sequence = numbers.Split();
            string[] newNumbers = sequence;

            for (int i = 0; i < newNumbers.Length; i++)
            {
                try
                {
                    int number = Int32.Parse(newNumbers[i]);
                    sum += number;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("{0}: {1}", newNumbers[i], ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("{0}: {1}", newNumbers[i], ex.Message);
                }
            }

            return sum;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Sorter ob = new Sorter();
            ob.Length = length;
            ob.Array = arr;

            ob.BubleSort();
            Console.WriteLine("Performing BubleSort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            ob.SelectionSort();
            Console.WriteLine("\nPerforming SelectionSort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            ob.InsertionSort();
            Console.WriteLine("\nPerforming InsertionSort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }

    
}

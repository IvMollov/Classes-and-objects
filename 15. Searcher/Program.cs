﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Searcher
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

            BubleSort(arr);

            Console.Write("\nSorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\nEnter number to be found: ");
            int number = int.Parse(Console.ReadLine());

            Searcher ob = new Searcher();
            ob.Array = arr;
            ob.Number = number;
            ob.Start = 0;
            ob.End = arr.Length - 1;
            Console.WriteLine("\nPerforming BinarySearch:");
            int position;
            position = ob.BinarySearch();
            if (position < 0)
            {
                Console.WriteLine("Number {0} was not found", number, position);
            }
            else
            {
                Console.WriteLine("Number {0} found at index {1}", number, position);
            }

            Console.WriteLine("\nPerforming LinearSearch:");
            position = ob.LinearSearch();
            if (position < 0)
            {
                Console.WriteLine("Number {0} was not found", number, position);
            }
            else
            {
                Console.WriteLine("NUmber {0} found at index {1}", number, position);
            }
            Console.ReadLine();
        }

        public static void BubleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
       
}

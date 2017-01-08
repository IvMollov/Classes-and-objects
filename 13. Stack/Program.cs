using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack ob = new Stack();

            for (int i = 100; i < 201; i++)
            {
                ob.Push(i);
            }
            Console.WriteLine("Is stack empty? {0}", ob.IsEmpty());
            Console.WriteLine("Is stack full? {0}", ob.IsFull());
            for (int i = 100; i < 201; i++)
            {
                Console.WriteLine("Last element is: {0}", ob.Pop());
            }
            Console.WriteLine("Is stack full? {0}", ob.IsFull());
            Console.WriteLine("Is stack empty? {0}", ob.IsEmpty());
        }
    }

   
}

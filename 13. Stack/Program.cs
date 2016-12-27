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

    class Stack
    {
        private int[] array = new int[101];
        private int top = - 1;

        public int Array
        {
            get; set;
        }
        public int Top
        {
            get; 
        }

        public void Push(int num)
        {
            if (top == array.Length - 1)
            {
                throw new IndexOutOfRangeException("Stack overflow.");
            }
            
            top++;
            array[top] = num;
        }
        public int Pop()
        {
            if (top == -1)
            {
                throw new IndexOutOfRangeException("No elements. Stack is empty.");
            }
            else
            {
                return array[top--];
            }
            
        }
        public int Peek()
        {
            return array[top];
        }
        public bool IsFull()
        {
            bool isFull = false;
            if (top == array.Length - 1)
            {
                
                return isFull = true;
            }
            else
            {
                return isFull = false;
            }
        }
        public bool IsEmpty()
        {
            bool isEmpty = false;
            if(top == -1)
            {
               return isEmpty = true;
            }
            else
            {
                return isEmpty;
            }
}
    }
}

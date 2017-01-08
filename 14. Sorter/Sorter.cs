using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Sorter
{
    public class Sorter
    {
       private int length;
        private int[] array;

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }

        public int[] Array
        {
            get
            {
                return this.array;
            }
            set
            {
                this.array = value;
            }
        }
        public void BubleSort()
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
        public void SelectionSort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (array[min] != i)
                {
                    int temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }
        }
        public void InsertionSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int valueToInsert = array[i];
                int position = i;
                while (position > 0 && array[position - 1] > valueToInsert)
                {
                    array[position] = array[position - 1];
                    position--;
                }
                array[position] = valueToInsert;
            }
        }
    }
}



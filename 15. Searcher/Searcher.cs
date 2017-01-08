using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Searcher
{
    public class Searcher
    {
        private int[] array;
        private int start;
        private int end;
        private int number;

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
        public int Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public int End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public int BinarySearch()
        {
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (array[middle] == number)
                {
                    return middle;
                }
                else if (number < array[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }
            return -1;
        }
        public int LinearSearch()
        {
            while (start <= end)
            {

                if (array[start] == number)
                {
                    return start;
                }
                start++;
            }
            return -1;
        }
    }
}

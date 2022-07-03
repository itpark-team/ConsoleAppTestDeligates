using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestDeligates
{
    internal class MyArray
    {
        private int[] _array;

        public MyArray(params int[] numbers)
        {
            _array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                _array[i] = numbers[i];
            }
        }

        public void Print()
        {
            foreach (int item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Sort(Func<int, int, bool> comparator)
        {
            bool isSorted = false;
            int offset = 0;

            do
            {
                isSorted = true;
                for (int i = 0; i < _array.Length - 1 - offset; i++)
                {
                    if (comparator(_array[i], _array[i + 1]) == true)
                    {
                        isSorted = false;

                        int temp = _array[i + 1];
                        _array[i + 1] = _array[i];
                        _array[i] = temp;
                    }
                }

                offset++;
            }
            while (isSorted == false);
        }
    }
}

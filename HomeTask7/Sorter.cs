using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public abstract class Sorter<T> : ISorter<T>
    {
        protected T[] arrayForSorting;

        public T[] ArrayForSorting
        {
            private set
            {
                if (value.Length > 0)
                {
                    arrayForSorting = value;
                }
                else
                {
                    Console.WriteLine("Error: cannot sort array with '0' elements.");
                }
            }

            get { return arrayForSorting; }
        }


        public Sorter(T[] arrayForSorting)
        {
            this.ArrayForSorting = arrayForSorting;
        }

        public void Print()
        {
            foreach (var item in arrayForSorting)
            {
                Console.Write("{0}   ", item);
            }
            Console.WriteLine();
        }

        public abstract void Sort();

        protected void Swap(int firstIndexForSwap, int secondIndexForSwap)
        {
            
            T temp = default(T);
            temp = arrayForSorting[firstIndexForSwap];
            arrayForSorting[firstIndexForSwap] = arrayForSorting[secondIndexForSwap];
            arrayForSorting[secondIndexForSwap] = temp;
            

            /*
            firstIndexForSwap ^= secondIndexForSwap;
            secondIndexForSwap ^= firstIndexForSwap;
            firstIndexForSwap ^= secondIndexForSwap;
            */
        }

    }
}

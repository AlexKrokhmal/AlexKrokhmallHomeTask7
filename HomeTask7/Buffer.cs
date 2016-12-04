using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected T[] arrayForElements;
        protected int arraySize;


        public int ArraySize
        {
            private set
            {
                if (value > 0)
                {
                    arraySize = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("It should contain at least 1 element");
                }
            }
            get
            {
                return arraySize;
            }
        }


        public Buffer(int arraySize)
        {
            this.ArraySize = arraySize;
            arrayForElements = new T[this.arraySize];
        }
        

        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peek();

        public void Print()
        {
            foreach (var item in arrayForElements)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        private int stackTail;


        public MyStack(int arraySize) : base(arraySize)
        {
            stackTail = 0;
        }


        public override bool IsEmpty()
        {
            if (stackTail == 0)
            {
                Console.WriteLine("The stack is empty.");
                return true;
            }
            else
            {
                Console.WriteLine("The stack is not empty.");
                return false;
            }
        }

        public override bool IsFull()
        {
            if (stackTail == arraySize)
            {
                Console.WriteLine("The stack is full.");
                return true;
            }
            else
            {
                Console.WriteLine("The stack is not full.");
                return false;
            }
        }

        public override T Peek()
        {
            Console.WriteLine("\nTry to peek the element.");

            T valueToReturn = default(T);

            if (!IsEmpty())
            {
                valueToReturn = arrayForElements[stackTail - 1];
            }
            else
            {
                Console.WriteLine("Cannot peek element from the stack. The stack is empty.");
            }

            return valueToReturn;
        }

        public T Pop()
        {
            Console.WriteLine("\nTry to pop the element.");

            T valueToReturn = default(T);

            if (!IsEmpty())
            {
                valueToReturn = arrayForElements[stackTail - 1];
                arrayForElements[stackTail - 1] = default(T);
                stackTail--;
            }
            else
            {
                Console.WriteLine("Cannot pop element from the stack. The stack is empty.");
            }

            return valueToReturn;
        }

        public void Push(T valueToAdd)
        {
            Console.WriteLine("\nTry to push the element.");

            if (!IsFull())
            {
                arrayForElements[stackTail] = valueToAdd;
                stackTail++;
            }
            else
            {
                Console.WriteLine("Cannot add value to the stack. The stack is already full.");
            }
        }
    }
}

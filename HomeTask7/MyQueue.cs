using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int queueHead;
        private int queueTail;
        private int numberOfUtilizedQueueElements;


        public MyQueue(int arraySize) : base(arraySize)
        {
            queueHead = 0;
            queueTail = 0;
            numberOfUtilizedQueueElements = 0;
        }
             

        public override bool IsEmpty()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == 0)
            {
                Console.WriteLine("The queue is empty.");
                returnValue = true;
            }

            return returnValue;
        }

        public override bool IsFull()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == arrayForElements.Length)
            {
                Console.WriteLine("The queue is full.");
                returnValue = true;
            }

            return returnValue;
        }

        public override T Peek()
        {
            T returnValue = default(T);

            if (!IsEmpty())
            {
                returnValue = arrayForElements[queueHead];                
            }
            else
            {
                Console.WriteLine("Cannot dequeue from the queue");
            }

            return returnValue;            
        }

        private int WhatIsNextCellIndexForTailOrHead(int currentIndex)
        {
            int returnValue = 0;

            if (currentIndex < arrayForElements.Length - 1)
            {
                returnValue = currentIndex + 1;
            }

            return returnValue;
        }

        /*
        private int WhatIsTheLastUsedElement(int currentIndex)
        { 
            if (currentIndex == 0)
            {
                return arrayForElements.Length - 1;                
            }
            else
            {
                return currentIndex - 1;
            }           
        }
        */

        public void Enqueue(T valueToAdd)
        {
            if (!IsFull())
            {
                arrayForElements[queueTail] = valueToAdd;
                queueTail = WhatIsNextCellIndexForTailOrHead(queueTail);
                numberOfUtilizedQueueElements++;
            }
            else
            {
                Console.WriteLine("Cannot enqueue the queue.");
            }
        }

        public T Dequeue()
        {
            T returnValue = default(T);

            if (!IsEmpty())
            {
                returnValue = arrayForElements[queueHead];
                arrayForElements[queueHead] = default(T);
                queueHead = WhatIsNextCellIndexForTailOrHead(queueHead);
                numberOfUtilizedQueueElements--;
            }
            else
            {
                Console.WriteLine("Cannot dequeue from the queue");                
            }

            return returnValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public class BubbleSorter<T> : Sorter<T> where T : IComparable<T>
    {
        public BubbleSorter(T[] arrayForSorting) : base(arrayForSorting)
        {
        }

                
        public override void Sort()
        {            
            bool swapWasDone = false;

            Console.WriteLine("\n\n***** Bubble Sorting *****\n");
            Console.WriteLine("Incoming array before sorting");
            Print();

            int iterationCounter = 1;

            do
            {
                swapWasDone = false;

                Console.WriteLine("Iteration {0}:", iterationCounter);

                for (int i = 0; i < arrayForSorting.Length - 1; i++)
                {
                    if (arrayForSorting[i].CompareTo(arrayForSorting[i + 1]) > 0)
                    {
                        Swap(i, i + 1);
                        swapWasDone = true;
                    }
                    Console.WriteLine("Step {0} result:", i + 1);
                    Print();
                }

                iterationCounter++;

            } while (swapWasDone);

            Console.WriteLine("\nThe result is:");
            Print();
        }
        
    }
}

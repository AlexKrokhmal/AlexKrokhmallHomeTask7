using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrayForBubbleSorting = new int[] { 4, 3, 1, 2, 1, 6, 5 };
            int[] arrayForInsertionSorting = (int[])arrayForBubbleSorting.Clone();

            string[] stringArrayForBubbleSorting = new string[] {"B", "a", "b", "c", "b" };
            string[] stringArrayForInsertionSorting = (string[])stringArrayForBubbleSorting.Clone();

            var TestIntBubble = new BubbleSorter<int>(arrayForBubbleSorting);

            var TestStringBubble = new BubbleSorter<string>(stringArrayForBubbleSorting);
            
            TestIntBubble.Print();
            TestIntBubble.Sort();

            TestStringBubble.Print();
            TestStringBubble.Sort();
            

            var TestIntInsertion = new InsertionSorter<int>(arrayForInsertionSorting);

            var TestStringInsertion = new InsertionSorter<string>(stringArrayForInsertionSorting);
            
            TestIntInsertion.Print();
            TestIntInsertion.Sort();
                        

            TestStringInsertion.Print();
            TestStringInsertion.Sort();

            
            Console.WriteLine("\n\n");

            var newTestQueue = new TestMyQueue();
            newTestQueue.TestTheQueue();

            var newTestStack = new TestMyStack();
            newTestStack.TestTheStack();
            
            /*
            var anotherQueue = new MyQueue<InsertionSorter<string>>(3);
            anotherQueue.Print();
            
            anotherQueue.Enqueue(TestStringInsertion);
            anotherQueue.Print();
            */



            Console.ReadLine();

        }
    }
}

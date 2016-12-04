using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public class TestMyQueue
    {
        public void TestTheQueue()
        {
            var newQueue = new MyQueue<int>(5);

            Console.WriteLine("-----------------\n");
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to peek");
            Console.WriteLine(newQueue.Peek());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");            
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(1);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(2);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(3);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(4);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to peek");
            Console.WriteLine(newQueue.Peek());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(5);
            newQueue.Print();
            Console.WriteLine("-----------------\n");
                        
            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(6);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to peek");
            Console.WriteLine(newQueue.Peek());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to peek");
            Console.WriteLine(newQueue.Peek());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(7);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(8);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(9);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            Console.WriteLine(newQueue.Dequeue());
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(10);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

        }


    }
}

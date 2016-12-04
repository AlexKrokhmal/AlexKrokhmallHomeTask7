using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    public class TestMyStack
    {
        public void TestTheStack()
        {
            var newStack = new MyStack<string>(3);
            newStack.Print();

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("a");
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("b");
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("c");
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("d");
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("e");
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("f");
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push("g");
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");
        }


    }
}

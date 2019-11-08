using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_1
{
    class StackTask
    {
        public void makeStack()
        {
            Stack mySteck = new Stack();

            mySteck.Push("Lone");
            mySteck.Push("Fjaak");
            mySteck.Push("Randomer");
            mySteck.Push("Mall Grab");
            mySteck.Push("Seinfeld");

            foreach (var i in mySteck)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }

        public void peekStack()
        {
            Stack mySteck = new Stack();

            mySteck.Push("Lone");
            mySteck.Push("Fjaak");
            mySteck.Push("Randomer");
            mySteck.Push("Mall Grab");
            mySteck.Push("Seinfeld");

            var peekMaster = mySteck.Peek();

            foreach (var i in mySteck)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(peekMaster);
            Console.WriteLine();

        }

        public void popStack()
        {
            Stack mySteck = new Stack();

            mySteck.Push("Lone");
            mySteck.Push("Fjaak");
            mySteck.Push("Randomer");
            mySteck.Push("Mall Grab");
            mySteck.Push("Seinfeld");

            var popMaster = mySteck.Pop();

            foreach (var i in mySteck)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(popMaster);
            Console.WriteLine();

        }

        public void intStack()
        {
            Stack<int> intSteck = new Stack<int>();

            intSteck.Push(10);
            intSteck.Push(9);
            intSteck.Push(8);
            intSteck.Push(7);
            intSteck.Push(6);
            intSteck.Push(5);
            intSteck.Push(4);
            intSteck.Push(3);
            intSteck.Push(2);
            intSteck.Push(1);

            foreach (var i in intSteck)
            {
                Console.WriteLine(i);
            }

        }
    }
}

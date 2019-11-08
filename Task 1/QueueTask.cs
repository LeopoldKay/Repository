using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_1
{
    class QueueTask
    {
        public void makeQueue()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue("Lone");
            myQueue.Enqueue("Fjaak");
            myQueue.Enqueue("Randomer");
            myQueue.Enqueue("Mall Grab");
            myQueue.Enqueue("Seinfeld");

            foreach (var i in myQueue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void deqQueue()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue("Lone");
            myQueue.Enqueue("Fjaak");
            myQueue.Enqueue("Randomer");
            myQueue.Enqueue("Mall Grab");
            myQueue.Enqueue("Seinfeld");

            var deqMaster = myQueue.Dequeue();

            foreach (var i in myQueue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(deqMaster);
            Console.WriteLine();
        }

        public void peekQueue()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue("Lone");
            myQueue.Enqueue("Fjaak");
            myQueue.Enqueue("Randomer");
            myQueue.Enqueue("Mall Grab");
            myQueue.Enqueue("Seinfeld");

            var peekMaster = myQueue.Peek();

            foreach (var i in myQueue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(peekMaster);
            Console.WriteLine();
        }

        public void intQueue()
        {

            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);

            foreach (var i in myQueue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}

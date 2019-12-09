using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_11_p._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 11 p.3");
            Stopwatch timer = new Stopwatch();
            ThreadStart secondThreadDelegate = FiboTask.SecondThreadMethod;
            Thread threadTwo = new Thread(secondThreadDelegate);
            threadTwo.Start();

            
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"1sh Thread ID: {threadId}");

            timer.Start();
            for (int i = 1; i <= 20; ++i)
            {
                Console.Write("{0}; ", FiboTask.Fib(i));
            }
            timer.Stop();
            Console.WriteLine($"\n1sh Thread {threadId} is over. Time: " + timer.Elapsed);
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Task 11 p.4");
            Thread thread3 = new Thread(AsyncTask.StartAsync);
            thread3.Start();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_11_p._2
{
    public class FiboTask
    {
        public static int Fib(int n)
        {
            return n == 1 || n == 2 ? 1 : Fib(n - 1) + Fib(n - 2);
        }

        public static void SecondThreadMethod()
        {
            Stopwatch timer = new Stopwatch();
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"2nd Thread Id: {threadId}");
            timer.Start();
            for (int i = 1; i <= 20; ++i)
            {
                Console.Write("{0}; ", Fib(i));
            }
            timer.Stop();
            Console.WriteLine($"\n2nd Thread {threadId} is over. Time: " + timer.Elapsed);


        }

    }

}

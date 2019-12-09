using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_11_p._2
{
    class AsyncTask
    {
        public delegate void AsyncDeligate();

        public static void StartAsync()
        {
            AsyncDeligate async = RunAsync;
            async.BeginInvoke(null, null);
            
            Console.WriteLine("Main finished");

        }

        private static async void RunAsync()
        {
            Console.WriteLine("Async Method is starting");
            await Task.Run(() => { WriteToFile(); });
            Console.WriteLine("Async Method finished");
        }

        public static void WriteToFile()
        {
            Thread.Sleep(5000);
            var fileInfo = new FileInfo(@"C:\Users\mrleo\OneDrive\Рабочий стол\Repository\Task 11\Task 11 p.2\ShowFileInfo.txt");

            using (StreamWriter writer = fileInfo.CreateText())
            {
                writer.WriteLine("ExampleLine1");
                Console.WriteLine("Lines are written to the file");
            }
                       
        }
    }

}


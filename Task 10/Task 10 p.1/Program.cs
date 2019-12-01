using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_p._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 10 - part 1:");
            CreateService create = new CreateService();
            create.CreateTask();
            create.CreateTask2();

            Console.WriteLine("Task 10 - part 2:");
            var t10object = new T10ClassWAtr();
            var atrList = t10object.GetType().GetMethods();
            foreach (var i in atrList)
                foreach (var a in i.CustomAttributes)
                    Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}

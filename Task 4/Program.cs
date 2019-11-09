using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public delegate T MyDelegata<T, R>(R indx1, R indx2);
    public delegate void MyDeligate2();
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2 :");
            Console.WriteLine();

            MyDelegata<int, int> del1 = (x, y) => x + y;
            Console.WriteLine("16 + 23 = " + del1(15, 23));
             
            MyDelegata<string, string> del2 = (x, y) => x + " / " + y;
            Console.WriteLine(del2("Возвращаем", "String"));

            Console.WriteLine();
            Console.WriteLine("Задание 3 :");
            Console.WriteLine();

            Methods myMethods = new Methods();
            myMethods.EventLong();
            myMethods.EventAnanim();
            myMethods.EventLyamda();

            Console.ReadKey();

        }

    }

}

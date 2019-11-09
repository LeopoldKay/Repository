using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public delegate T MyDelegata<T>(T indx1, T indx2);
    public delegate void MyDeligate2();
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2 :");
            Console.WriteLine();

            MyDelegata<int> del1 = (x, y) => x + y;
            Console.WriteLine("16 + 23 = " + del1(15, 23));

            MyDelegata<string> del2 = (x, y) => x + " / " + y;
            Console.WriteLine(del2("Возвращаем", "String"));

            Console.WriteLine();
            Console.WriteLine("Задание 3 :");
            Console.WriteLine();

            MyElements myElement = new MyElements();

            MyDeligate2 ElemementHandler = delegate
            {
                Console.WriteLine("Это обработчик события !!!");
            };

            // myElement.MyEvent += delegate { Console.WriteLine("Это обработчик события !!!"); };

            myElement.MyEvent += () => Console.WriteLine("Это обработчик события !!!");

            myElement.InvokeEvent();

            Console.ReadKey();

        }

    }

}

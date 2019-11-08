using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public delegate void CrWolf2();
    class Program
    {
        public delegate BigBadWolf CreateWolf(string name);
        public delegate void Description();
        public delegate void ForWoof();
        public delegate void Simple();
        
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Task 2");
            Console.WriteLine();
            Method method = new Method();
       
            CreateWolf wolf = method.crWolf;

            wolf("BioWolf").wolf2();

            Description Descript = delegate
            {
                Console.WriteLine("Делегат который выводит имя волка");

            };

            Descript();
            Console.WriteLine();
            Console.WriteLine("Task 2");
            Console.WriteLine();
            Simple simple1 = simpleMethod1;
            Simple simple2 = simpleMethod2;
            Simple simple3 = simpleMethod3;
            Simple simple4 = simpleMethod4;
            Simple simple5 = simpleMethod5;

            Simple simple = simple1 + simple2 + simple3 - simple4;

            simple();

            void simpleMethod1()
            {
                Console.WriteLine("Это метод 1");
            }

            void simpleMethod2()
            {
                Console.WriteLine("Это метод 2");
            }

            void simpleMethod3()
            {
                Console.WriteLine("Это метод 3");
            }

            void simpleMethod4()
            {
                Console.WriteLine("Это метод 4");
            }

            void simpleMethod5()
            {
                Console.WriteLine("Это метод 5");
            }


            Console.ReadKey();
        }

        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    
    class BigBadWolf
    {
        
        public static string name;
        
        public CrWolf2 wolf2 = PrintWolfName;
        public static void PrintWolfName()
        {

            Console.WriteLine("Wolf Name: " + name);
        }


        public void Woof()
        {
            Console.WriteLine("Woof-Woof");

        }
    }
}

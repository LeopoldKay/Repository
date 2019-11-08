using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{
    class Class1 : DictionaryInterface
    {
        public int ver;

        public Class1(int ver)
        {
            this.ver = ver;
        }

        public void Message()
        {
            Console.WriteLine(" Это класс 1");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_1
{
    class ArrayListTask
    {
        public void makeArrayList()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("one");
            arrayList.Add("two");
            arrayList.Add("three");
            arrayList.Add("four");
            arrayList.Add("five");

            Console.WriteLine("Vivod Cherez For:");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine("Vivod Cherez Foreach:");

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
        public void UdalrnieIzArrayList()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("one");
            arrayList.Add("two");
            arrayList.Add("three");
            arrayList.Add("four");
            arrayList.Add("five");

            Console.WriteLine("Udalenie po indexu (1):");

            arrayList.Remove(arrayList[1]);

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Udalenie po soderjaniu (four):");

            arrayList.Remove("four");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }

        public void KonstruktArrayList()
        {
            Console.WriteLine("Sozdaem novi spisok i zapolnyaem konstruktorom");

            ArrayList arrayList1 = new ArrayList()
            {
                "six",
                "seven",
                "eight",
                "nine",
                "ten"
            };
            foreach (var i in arrayList1)
            {
                Console.WriteLine(i);
            }
        }
    }
}

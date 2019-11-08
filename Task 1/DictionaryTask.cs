using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class DictionaryTask
    {
        public void myDictionary()
        {
            Dictionary<interf1, interf2> myDictionary1 = new Dictionary<interf1, interf2>();

            interf1 one = new interf1(1);
            interf1 two = new interf1(2);
            interf1 three = new interf1(3);

            interf2 vol1 = new interf2("Lone");
            interf2 vol2 = new interf2("Fjaak");
            interf2 vol3 = new interf2("Randomer");

            myDictionary1.Add(one, vol1);
            myDictionary1.Add(two, vol2);
            myDictionary1.Add(three, vol3);

            foreach (var i in myDictionary1)
            {
                Console.WriteLine(i.Key.x + "/" + i.Value.y);
            }
        }
    }

    class interf1
    {
        public int x;

        public interf1(int x)
        {
            this.x = x;
        }
    }

    class interf2
    {
        public string y;

        public interf2(string y)
        {
            this.y = y;
        }
    }
}

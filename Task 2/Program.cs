using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyCollection Realization:");
            Console.WriteLine();
            MyCollection<int> myCollection = new MyCollection<int>();

            myCollection.ListColl = new List<int>();
            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);
            myCollection.Add(4);
            myCollection.Add(5);
            myCollection.Add(6);
            myCollection.Add(7);
            myCollection.Add(8);
            myCollection.Add(9);
            myCollection.Add(10);
            myCollection.Add(11);

            foreach (var i in myCollection)
            {
                Console.WriteLine(i);
            }
            myCollection.Remove(11);
            myCollection.Remove(10);
            myCollection.Remove(9);
            myCollection.Remove(8);
            myCollection.Remove(7);
            myCollection.Remove(6);
            myCollection.Remove(5);
            myCollection.Remove(4);
            myCollection.Remove(3);

            Console.WriteLine();
            Console.WriteLine("GenericClass Realization:");
            Console.WriteLine();

            Dictionary<DictionaryInterface, DictionaryInterface> newDictionary = new Dictionary<DictionaryInterface, DictionaryInterface>();

            Class1 class1 = new Class1(1);

            Class1 class2 = new Class1(2);

            Class2 class3 = new Class2(3);

            Class2 class4 = new Class2(4);


            newDictionary.Add(class1, class2);
            newDictionary.Add(class3, class4);

            foreach (var i in newDictionary)
            {
                if (i.Key is Class1)
                {
                    Console.WriteLine((i.Key as Class1).ver + "/" + (i.Value as Class1).ver);
                }
                else
                    Console.WriteLine((i.Key as Class2).ver + "/" + (i.Value as Class2).ver);
            }

            Console.ReadKey();
        }
    }
}

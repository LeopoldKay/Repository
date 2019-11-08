using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListTask arrayListTask = new ArrayListTask();
            arrayListTask.makeArrayList();
            arrayListTask.UdalrnieIzArrayList();
            arrayListTask.KonstruktArrayList();

            LinkedLisTask linkedLisTask = new LinkedLisTask();
            linkedLisTask.makeLinkedList();
            linkedLisTask.DelateFroCentre();

            StackTask stackTask = new StackTask();

            stackTask.makeStack();
            stackTask.peekStack();
            stackTask.popStack();
            stackTask.intStack();

            QueueTask queueTask = new QueueTask();

            queueTask.makeQueue();
            queueTask.deqQueue();
            queueTask.peekQueue();
            queueTask.intQueue();

            DictionaryTask dictionaryTask = new DictionaryTask();

            dictionaryTask.myDictionary();

            HashSetTask hashSetTask = new HashSetTask();

            hashSetTask.myHashSet();
            hashSetTask.ContRem();
            hashSetTask.Union();
            hashSetTask.Exept();
            hashSetTask.Insert();


            Console.ReadKey();
        }
    }
}

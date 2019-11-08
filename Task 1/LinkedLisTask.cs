using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class LinkedLisTask
    {
        public void makeLinkedList()
        {

            Console.WriteLine("Collection LinkedList");
            LinkedList<string> linkList = new LinkedList<string>();

            linkList.AddFirst("One");
            linkList.AddFirst("Two");
            linkList.AddBefore(linkList.Last, "Thee");
            linkList.AddAfter(linkList.First, "Four");
            linkList.AddAfter(linkList.Last, "Five");
            linkList.AddAfter(linkList.Last, "Seven");
            linkList.AddAfter(linkList.Last, "Eight");
            linkList.AddAfter(linkList.Last, "Nine");
            linkList.AddAfter(linkList.Last, "Ten");
            linkList.AddBefore(linkList.Find("Five"), "11");

            LinkedListNode<string> linkNode = linkList.First;

            Console.WriteLine("Выводим 2й элемент списка:");
            Console.WriteLine(linkList.ElementAt(2));

            Console.WriteLine("Выводим весь список:");
            linkNode = linkList.First;
            while (linkNode != null)
            {
                Console.WriteLine(linkNode.Value);
                linkNode = linkNode.Next;
            }
        }
        public void DelateFroCentre()
        {

            LinkedList<string> linkList = new LinkedList<string>();

            linkList.AddFirst("One");
            linkList.AddFirst("Two");
            linkList.AddBefore(linkList.Last, "Thee");
            linkList.AddAfter(linkList.First, "Four");
            linkList.AddAfter(linkList.Last, "Five");
            linkList.AddAfter(linkList.Last, "Seven");
            linkList.AddAfter(linkList.Last, "Eight");
            linkList.AddAfter(linkList.Last, "Nine");
            linkList.AddAfter(linkList.Last, "Ten");
            linkList.AddBefore(linkList.Find("Five"), "11");

            LinkedListNode<string> linkNode = linkList.First;
            Console.WriteLine("Bыводим:");
            linkList.RemoveFirst();
            linkList.Remove(linkList.First);
            linkList.RemoveLast();

            linkList.Remove(linkList.Find("11"));

            Console.WriteLine("Bыводим весь без 11:");
            linkNode = linkList.First;
            while (linkNode != null)
            {
                Console.WriteLine(linkNode.Value);
                linkNode = linkNode.Next;
            }
        }
    }
}

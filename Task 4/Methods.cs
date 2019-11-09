using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Methods
    {
        public void EventLong()
        {
            MyElements myElement = new MyElements();

            MyDeligate2 ElemementHandler = new MyDeligate2(MethdHandler);

            myElement.MyEvent += ElemementHandler;

            myElement.InvokeEvent();

            void MethdHandler()
            {
                Console.WriteLine("Long version event realisation !!!");
            }

        }

        public void EventAnanim()
        {
            MyElements myElement = new MyElements();

            MyDeligate2 ElemementHandler = delegate
            {
                Console.WriteLine("Ananim version event realisation !!!");
            };

            myElement.MyEvent += ElemementHandler;
            myElement.InvokeEvent();

        }

        public void EventLyamda()
        {
            MyElements myElement = new MyElements();
            MyDeligate2 ElemementHandler = () => Console.WriteLine("Lyamda version event realisation !!!");

            myElement.MyEvent += ElemementHandler; 
            myElement.InvokeEvent();
        }
    }
}

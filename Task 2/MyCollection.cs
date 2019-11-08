using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_2
{
    class MyCollection<T> : IEnumerable where T : struct
    {
        public List<T> ListColl { get; set; }

        public IEnumerator GetEnumerator()
        {
            return new Interator<T>(this);
        }

        public static int ToInt32(object value)
        {
            if (value != null)
            {
                return ((IConvertible)value).ToInt32(null);
            }
            return 0;
        }

        public T showCell(int i)
        {
            return ListColl[i];
        }

        public void Add(T x)
        {
            if (ListColl.Count < 10)
            {
                ListColl.Add(x);
            }
            else Console.WriteLine("!!! Too many !!!");
        }

        public void Remove(T x)
        {
            if (ListColl.Count > 5)
            {
                ListColl.Remove(x);
            }
            else Console.WriteLine("!!! Reserved Can't Delete !!!");

        }

        class Interator<T> : IEnumerator where T : struct
        {
            List<T> listColl;

            public Interator(MyCollection<T> myCollection)
            {
                listColl = myCollection.ListColl;
            }

            int currentPosition = -1;

            public object Current
            {
                get
                {
                    return listColl[currentPosition];
                }
            }

            public bool MoveNext()
            {
                if (currentPosition < listColl.Count - 1)
                {
                    currentPosition++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                currentPosition = -1;
            }
        }
    }
}

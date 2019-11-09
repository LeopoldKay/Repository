using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class MyElements
    {
        public event MyDeligate2 MyEvent;

        public void InvokeEvent()
        {
            MyEvent?.Invoke();
        }
    }
}

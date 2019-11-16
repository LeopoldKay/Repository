using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    static class MyStaticClass
    {
        public static void CallDelegate(MyDelegate myDelegate)
        {
            myDelegate();
        }
    }
}

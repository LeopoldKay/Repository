using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_p._1
{
    class T10ClassWAtr
    {
        [T10Attributes("Gregor")]
        public void PubMethod()
        {
            Console.WriteLine("This is Public Method with Attributes ");
        }

        [T10Attributes("Pontius", 700)]
        void PrvMethod()
        {
            Console.WriteLine("This is Privart Method with Attributes ");
        }
    }
}

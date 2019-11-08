using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Method
    {
        public BigBadWolf crWolf(string name)
        {
            BigBadWolf newWolf = new BigBadWolf();
            BigBadWolf.name = name;
            return newWolf;
        }
    }
}

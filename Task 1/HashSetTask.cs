using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class HashSetTask
    {
        public void myHashSet()
        {
            HashSet<string> myHashSet = new HashSet<string>();

            myHashSet.Add("Lone");
            myHashSet.Add("Fjaak");
            myHashSet.Add("Mall Grab");

            foreach (var i in myHashSet)
            {
                Console.WriteLine(i);
            }

        }

        public void ContRem()
        {
            HashSet<string> myHashSet = new HashSet<string>();

            myHashSet.Add("Lone");
            myHashSet.Add("Fjaak");
            myHashSet.Add("Mall Grab");

            if (myHashSet.Contains("Fjaak"))
            {
                myHashSet.Remove("Fjaak");
            }

            foreach (var i in myHashSet)
            {
                Console.WriteLine(i);
            }

        }

        public void Union()
        {
            HashSet<string> myHashSet = new HashSet<string>();
            HashSet<string> myHashSet1 = new HashSet<string>();

            myHashSet.Add("Lone");
            myHashSet.Add("Fjaak");
            myHashSet.Add("Mall Grab");

            myHashSet1.Add("Lone");
            myHashSet1.Add("Randomer");
            myHashSet1.Add("Seinfeld");

            myHashSet.UnionWith(myHashSet1);

            foreach (var i in myHashSet)
            {
                Console.WriteLine(i);
            }

        }

        public void Exept()
        {
            HashSet<string> myHashSet = new HashSet<string>();
            HashSet<string> myHashSet1 = new HashSet<string>();

            myHashSet.Add("Lone");
            myHashSet.Add("Fjaak");
            myHashSet.Add("Mall Grab");

            myHashSet1.Add("Lone");
            myHashSet1.Add("Randomer");
            myHashSet1.Add("Seinfeld");

            myHashSet.ExceptWith(myHashSet1);

            foreach (var i in myHashSet)
            {
                Console.WriteLine(i);
            }

        }

        public void Insert()
        {
            HashSet<string> myHashSet = new HashSet<string>();
            HashSet<string> myHashSet1 = new HashSet<string>();

            myHashSet.Add("Lone");
            myHashSet.Add("Fjaak");
            myHashSet.Add("Mall Grab");

            myHashSet1.Add("Lone");
            myHashSet1.Add("Randomer");
            myHashSet1.Add("Seinfeld");

            myHashSet.IntersectWith(myHashSet1);

            foreach (var i in myHashSet)
            {
                Console.WriteLine(i);
            }

        }
    }
}

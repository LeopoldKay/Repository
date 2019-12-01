using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_p._1
{
    [AttributeUsage(AttributeTargets.Method)]
    class T10Attributes : Attribute
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }

        public T10Attributes(string name, int age = 0, bool gender = true)
        {
            Name = name;
            Age = age;
            Gender = gender;

        }
    }
}

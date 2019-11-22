using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public enum BodyParts
    {
        Head,
        Legs,
        Arms
    }

    class Human
    {

        public BodyParts MostImportantBodyPart { get; set; } = BodyParts.Head;


    }

    static class HumanExtension
    {
        public static void Evolve(this Human human)
        {
            human.MostImportantBodyPart = BodyParts.Arms;
        }
    }

}

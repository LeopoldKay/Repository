using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public delegate void Action();
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Action myAction = delegate { Console.WriteLine("!!! This is static Method from p.1 !!!"); };
            NoStaticClass.MyMethod(myAction);

            Console.WriteLine("Part 2");
            MyStaticClass.CallDelegate(() => Console.WriteLine("!!! This is Method p.2 !!!"));

            Console.WriteLine("Part 3");
            Human myHuman = new Human();
            Console.WriteLine("Before Evolve: " + myHuman.MostImportantBodyPart.ToString());
            myHuman.Evolve();
            Console.WriteLine("After Evolve: " + myHuman.MostImportantBodyPart.ToString());

            Console.WriteLine("Part 4");
            var characters = PersonsService.GetPersons();
            var zapros = characters.Where(x => x.Age > 30).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var i in zapros)
                Console.WriteLine(i);
            
            Console.ReadKey();

        }
    }
}

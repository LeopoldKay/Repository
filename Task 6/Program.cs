using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            var persBase = PersonsService.GetPersons();  
            var pers = persBase.Select(PersonDescription => new { PersonDescription.Age, PersonDescription.FirstName, PersonDescription.Gender, PersonDescription.LastName });
            foreach (var y in pers)
                Console.WriteLine(y);

            Console.WriteLine("Part 2");
            var persBase2 = PersonsService.GetPersons();
            var pers2 = persBase2.Where(x => x.Age < 100).GroupBy(x => x.Gender).OrderBy(x => x.Count()).Select(x => new { x.Key, у = x.Count() });
            foreach (var l in pers2)
                Console.WriteLine(l.ToString());

            Console.ReadKey();


        }
    }
}

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
            var a = new { FirstName = persBase.Select(x=>x.FirstName), LastName = persBase.Select(x => x.LastName), Gender = persBase.Select(x=>x.Gender), Age = persBase.Select(x=>x.Age) };
            var pers = persBase.Select(PersonDescription => new { a });
            
            Console.WriteLine("Part 2");
            var persBase2 = PersonsService.GetPersons();
            var pers2 = persBase2.Where(x => x.Age < 100).GroupBy(x => x.Gender).GroupBy(group => group.Count()).Select(r => new { r.Key, у = r.Count(), e = r});
            foreach (var l in pers2)
                foreach (var s in l.e)
                    foreach(var b in s)
                    Console.WriteLine(l.ToString());
            
             

            Console.ReadKey();


        }
    }
}

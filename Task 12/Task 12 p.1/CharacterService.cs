using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_p._1
{
    class CharacterService
    {
        public static List<Human> GetCharacters()
        {
            var directors = new List<Human>();

            directors.Add(new Human() { FirstName = "Francis", LastName = "Coppola", BirthDate = new DateTime(1939, 4, 7) });
            directors.Add(new Human() { FirstName = "George", LastName = "Lucas", BirthDate = new DateTime(1944, 5, 14) });
            directors.Add(new Human() { FirstName = "Martin", LastName = "Scorsese ", BirthDate = new DateTime(1942, 11, 17) });

            return directors;
        }
    }

}

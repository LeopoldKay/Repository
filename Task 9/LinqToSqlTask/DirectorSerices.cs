using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlTask
{
    class DirectorSerices
    {
        public static List<Dir2> GetDirectors()
        {
            var directors = new List<Dir2>();

            directors.Add(new Dir2() { FirstName = "Francis", LastName = "Coppola", BirthDate = new DateTime(1939, 4, 7) });
            directors.Add(new Dir2() { FirstName = "Martin", LastName = "Scorsese", BirthDate = new DateTime(1942, 11, 17) });
            directors.Add(new Dir2() { FirstName = "Roman", LastName = "Polanski", BirthDate = new DateTime(1933, 8, 18) });
            directors.Add(new Dir2() { FirstName = "Unknown", LastName = "First", BirthDate = new DateTime(1956, 3, 15) });
            directors.Add(new Dir2() { FirstName = "Unknown", LastName = "Secomd", BirthDate = new DateTime(1963, 8, 7) });
            directors.Add(new Dir2() { FirstName = "Unknown", LastName = "Third", BirthDate = new DateTime(1975, 11, 23) });
            return directors;
        }
    }
}

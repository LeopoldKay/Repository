using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlTask
{
    class Services
    {

        public static List<Director> GetDirectors()
        {
            var directors = new List<Director>();

            directors.Add(new Director() { FirstName = "Francis", LastName = "Coppola", BirthDate = new DateTime(1939, 4, 7) });
            directors.Add(new Director() { FirstName = "Martin", LastName = "Scorsese", BirthDate = new DateTime(1942, 11, 17) });
            directors.Add(new Director() { FirstName = "Roman", LastName = "Polanski", BirthDate = new DateTime(1933, 8, 18) });
            directors.Add(new Director() { FirstName = "Darren", LastName = "Aronofsky ", BirthDate = new DateTime(1969, 2, 12) });
            directors.Add(new Director() { FirstName = "George", LastName = "Lucas", BirthDate = new DateTime(1944, 5, 14) });
            return directors;
        }

        public static List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie() { Name = "Star Wars", Genre = "Fantasy", Year = 1977, DirectorId = 5 });
            movies.Add(new Movie() { Name = "Rosemary's Baby", Genre = "Horror", Year = 1968, DirectorId = 3 });
            movies.Add(new Movie() { Name = "Scarface", Genre = "Action", Year = 1983, DirectorId = 2 });
            movies.Add(new Movie() { Name = "Пи", Genre = "Psychologic", Year = 1998, DirectorId = 4 });
            movies.Add(new Movie() { Name = "The Godfather", Genre = "Criminal", Year = 1998, DirectorId = 1 });

            return movies;
        }

    }
}

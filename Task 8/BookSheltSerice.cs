using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson8.Models;
using Lesson8;

namespace Task_8
{
    class BookSheltSerice
    {
        public static void CreateCharacter()
        {
            var persondbContext = new BookSheltContext();
            List<Character> characters = CinemaService.CharactersMethod();


            persondbContext.Characters.AddRange(characters);


            persondbContext.SaveChanges();

        }
      

        public static void Print()
        {
            var persondbContext = new BookSheltContext();
            var printList = persondbContext.Characters;

            foreach (var i in printList)
                Console.WriteLine($"Id: {i.Id},  \tFirstName: {i.FirstName}  " +
                    $"\tLastName: {i.LastName}  \tGender: {i.Gender}  \tAge: {i.Age}");

        }

        public static void AddRange()
        {
            var persondbContext = new BookSheltContext();
            List<Character> characters = CinemaService.CharactersMethod();
            persondbContext.Characters.AddRange(new List<Character> { characters[2], characters[3], characters[4], characters[5] });
            persondbContext.SaveChanges();
        }

        public static List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie() { Genre = "Fantasy", Name = "Star Wars", Year = 1978 });
            movies.Add(new Movie() { Genre = "Action", Name = "Star Wars", Year = 1982 });
            movies.Add(new Movie() { Genre = "Drama/Crime", Name = "GodFather", Year = 1972 });

            return movies;
        }

        public static void CreateMoviesTable()
        {
            var moviesContext = new BookSheltContext();
            List<Movie> movies = GetMovies();

            moviesContext.Movies.AddRange(movies);
            moviesContext.SaveChanges();
        }

        public static void PrintMovieTbl()
        {
            var persondbContext = new BookSheltContext();
            var printList = persondbContext.Movies;

            foreach (var i in printList)
                Console.WriteLine($"Id: {i.Id},  \tGenre: {i.Genre}  " +
                    $"\tName: {i.Name}  \tYear: {i.Year}");
        }
    }
}

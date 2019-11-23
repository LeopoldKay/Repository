using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realisation Part 1 & 2.");
            BookSheltSerice.CreateCharacter();
            BookSheltSerice.Print();
            Console.WriteLine("Realisation Part 3.");
            BookSheltSerice.AddRange();
            BookSheltSerice.Print();
            Console.WriteLine("Realisation Part 4 & 5.");
            BookSheltSerice.CreateMoviesTable();
            BookSheltSerice.PrintMovieTbl();

            Console.ReadKey();
        }
    }
}

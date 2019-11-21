using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 2: Make Table.");
            CrtTables.MoviesTable();
            Console.WriteLine("Part 3: Fill Table.");
            CrtTables.FillTable();
            Console.WriteLine("Part 4: Print table.");
            CrtTables.PrintTabel();

            Console.ReadKey();
        }
    }
}

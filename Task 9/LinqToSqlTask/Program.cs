using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataConext = new DataContext(ConfigurationManager.ConnectionStrings["DirectrsContext"].ToString());
            var dirList = DirectorSerices.GetDirectors();
            dataConext.GetTable<Dir2>().InsertAllOnSubmit(dirList);
            dataConext.SubmitChanges();
            var printList = dataConext.GetTable<Dir2>();
            Console.WriteLine("Task 1 - Add Directors:");
            foreach (var i in printList)
                Console.WriteLine("First Name: " + i.FirstName + " / Last Name: " + i.LastName + " / BirthDate: " + i.BirthDate.ToString("D"));

            var delList = dataConext.GetTable<Dir2>().Where(x => x.FirstName == "Unknown");
            dataConext.GetTable<Dir2>().DeleteAllOnSubmit(delList);
            dataConext.SubmitChanges();
            var printList2 = dataConext.GetTable<Dir2>();
            Console.WriteLine("Task 3 - Delete Directors List:");
            foreach (var i in printList2)
                Console.WriteLine("First Name: " + i.FirstName + " / Last Name: " + i.LastName + " / BirthDate: " + i.BirthDate.ToString("D"));

            Console.WriteLine("Adittions 3* & 4*: ");
            var directors = Services.GetDirectors();
            dataConext.GetTable<Director>().InsertAllOnSubmit(directors);
            dataConext.SubmitChanges();

            var movies = Services.GetMovies();
            dataConext.GetTable<Movie>().InsertAllOnSubmit(movies);
            dataConext.SubmitChanges();

            Console.ReadKey();


        }
    }
}

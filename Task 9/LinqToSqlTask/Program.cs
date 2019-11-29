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
            dataConext.GetTable<Director>().InsertAllOnSubmit(dirList);
            dataConext.SubmitChanges();
            var printList = dataConext.GetTable<Director>();
            Console.WriteLine("Add Directors:");
            foreach (var i in printList)
                Console.WriteLine("First Name: " + i.FirstName + " / Last Name: " + i.LastName + " / BirthDate: " + i.BirthDate.ToString("D"));

            var delList = dataConext.GetTable<Director>().Where(x => x.FirstName == "Unknown");
            dataConext.GetTable<Director>().DeleteAllOnSubmit(delList);
            dataConext.SubmitChanges();
            var printList2 = dataConext.GetTable<Director>();
            Console.WriteLine("Delete Directors List:");
            foreach (var i in printList2)
                Console.WriteLine("First Name: " + i.FirstName + " / Last Name: " + i.LastName + " / BirthDate: " + i.BirthDate.ToString("D"));
            Console.ReadKey();


        }
    }
}

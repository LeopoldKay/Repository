using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class CrtTables
    {
        public static void MoviesTable()
        {
            var command = @"create table [dbo].[Movies](
	                        [Name] [nvarchar](50) NOT NULL,
	                        [Genre] [nvarchar](50) NULL,
	                        [Year] [int] NOT NULL
                            ) on [PRIMARY]
                           ";
            using (System.Data.SqlClient.SqlConnection conect = new SqlConnection())
            {
                conect.ConnectionString = ConfigurationManager.ConnectionStrings["Task7CS"].ToString();

                SqlCommand sqlCommand = new SqlCommand(command, conect);
                conect.Open();
                sqlCommand.ExecuteNonQuery();

            }

        }

        public static void FillTable()
        {
            var command = @"INSERT INTO [dbo].[Movies]
                            ([Name], [Genre], [Year])
                            VALUES
                            ('Star Wars', 'fantasy', 1977),
                            ('Blade Ranner', 'fantasy', 1982),
                            ('Johnny Mnemonic', 'fantasy', 1995)
                           ";
            using (System.Data.SqlClient.SqlConnection conect = new SqlConnection())
            {
                conect.ConnectionString = ConfigurationManager.ConnectionStrings["Task7CS"].ToString();

                SqlCommand sqlCommand = new SqlCommand(command, conect);
                conect.Open();
                sqlCommand.ExecuteNonQuery();

            }

        }

        public static void PrintTabel()
        {
            var command = @"select * from Movies";

            using (System.Data.SqlClient.SqlConnection conect = new SqlConnection())
            {
                conect.ConnectionString = ConfigurationManager.ConnectionStrings["Task7CS"].ToString();

                SqlCommand sqlCommand = new SqlCommand(command, conect);
                conect.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Name: {reader[0].ToString()}, Genre: {reader[1].ToString()}, Year: {reader[2].ToString()}");
                    }

                }

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_p._1
{
    class CreateService
    {
        DirectoryInfo directory = new DirectoryInfo(@"C:\Users\mrleo\OneDrive\Рабочий стол\Repository\Task 10\");
        FileInfo file = new FileInfo(@"C:\Users\mrleo\OneDrive\Рабочий стол\Repository\Task 10\NotExistingDir1\NotExistsingDir2\1stNewFile.txt");

        DirectoryInfo directory2 = new DirectoryInfo(@"C:\Users\mrleo\OneDrive\Рабочий стол\Repository\Task 10\NotExistingDir3\NotExistsingDir4\");
        FileInfo file2 = new FileInfo(@"C:\Users\mrleo\OneDrive\Рабочий стол\Repository\Task 10\NotExistingDir3\NotExistsingDir4\2ndNewFile.txt");

        public void CreateTask2()
        {
            try
            {
                file2.Create();
                Console.WriteLine("Cоздан фаел 2: " + file2.FullName);
            }
            catch (Exception e)
            {
                directory2.Create();
                CreateTask2();
                Console.WriteLine(e);
            }
        }

        public void CreateTask()
        {
             
            if (directory.Exists)
            {
                directory.CreateSubdirectory(@"NotExistingDir1\NotExistsingDir2\");
                file.Create();
                Console.WriteLine("Cоздан фаел 1: " + file.FullName);
            }
            else
            {
                Console.WriteLine("!!! Directory Not Exist !!!");
            }
        }

    }
}

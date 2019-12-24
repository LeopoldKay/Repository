using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Task_12_p._1
{
    class Program
    {
        static void Main(string[] args)
        {

            SaveToFile();
            RunSerializAsync();
            RunDeserialize();

            //Console.WriteLine("Main Operation finished");

            Console.ReadKey();

        }
        public static async void SaveToFile()
        {
            var oneHuman = new Human();
            oneHuman.FirstName = "Antonio";
            oneHuman.LastName = "Jobim";
            oneHuman.BirthDate = new DateTime(1942, 11, 17);

            using (FileStream stream = new FileStream(@"I:\Leopold Docs\C#\Study\Advance\MyTasks\Repository\Task 12\Task 12 p.1\File\oneHuman.txt", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(stream, oneHuman);
            }

            Console.WriteLine("Json file is created.");
        }

        private static async void RunSerializAsync()
        {
            Console.WriteLine("Async Operation started");
            await Task.Run(() => { SerializFile(); });
            Console.WriteLine("Async Operation finished");
        }

         
        public static async void RunDeserialize()
        {
            Human human;

            using (FileStream stream = new FileStream(@"I:\Leopold Docs\C#\Study\Advance\MyTasks\Repository\Task 12\Task 12 p.1\File\oneHuman.txt", FileMode.Open))
            {
                human = await JsonSerializer.DeserializeAsync<Human>(stream);
            }

            Console.WriteLine("Json human десериализован" + human.FirstName + " " + human.LastName);
        }


        public static void SerializFile()
        {

            Thread.Sleep(3000);
            var humanList = CharacterService.GetCharacters();

            using (FileStream stream = new FileStream(@"I:\Leopold Docs\C#\Study\Advance\MyTasks\Repository\Task 12\Task 12 p.1\File\Human.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(stream, humanList);
            }

            Console.WriteLine("Json humanList сериализован: " + humanList);

           
        }


    }

}

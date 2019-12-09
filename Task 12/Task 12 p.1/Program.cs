using System;
using System.Collections.Generic;
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
            
            RunSerializAsync();

            Console.WriteLine("Main Operation finished");

            Console.ReadKey();

        }

        private static async void RunSerializAsync()
        {
            Console.WriteLine("Async Operation started");
            await Task.Run(() => { SerializFile(); });
            Console.WriteLine("Async Operation finished");
        }


        public static void SerializFile()
        {
            var humanList = CharacterService.GetCharacters();

            Thread.Sleep(3000);
            
            string json = JsonSerializer.Serialize(humanList);
            Console.WriteLine("Json human сериализован: " + json);
            Thread.Sleep(3000);
            var human2 = JsonSerializer.Deserialize<List<Human>>(json);
            Console.WriteLine("Json human десериализован:\n");
            foreach (var i in human2)
            {
                Console.WriteLine("FirstName: " + i.FirstName + "; LastName: " + i.LastName);
            }
        }


    }

}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Serializer
{
    //Create class to serialize/deserialize
    public class DataStructure
    {
        public string Name { get; set; }
        public List<int> Identifiers { get; set; }

        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Identifiers: " + string.Join<int>(",", Identifiers));
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        const string filePath = @"E:\tit\Tasks\Quiz 1\Serializer\json.txt";
        //Create methods to serialize and deserialize
        public static void Serialize(object obj)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }

        static void Main(string[] args)
        {
            var data = new DataStructure
            {
                Name = "Mohamed Hassan",
                Identifiers = new List<int> { 1, 2, 3, 4 }
            };

            Console.WriteLine("Object before serialization:");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            data.Print();

            Serialize(data);

            var deserialized = Deserialize(filePath);

            Console.WriteLine("Deserialized (json) string:");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine(deserialized);
            Console.ReadKey();
        }
    }
}
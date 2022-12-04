using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
namespace XmlDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SerializeObjectToXmlString();
             SerializeObjectToXmlFile();
            //SerializeListToXmlFile();
            //  DeserializeXmlFileToList();

            Console.WriteLine("Process completed...");
            Console.ReadKey();
        }
        //console
       // 1 Serialize Object To XmlString
        private static void SerializeObjectToXmlString()
        {
            var member = new Member
            {
                Name = "Mohamed Hassan",
                Email = "mh0056592@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, member);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
                DeserializeXmlStringToObject(xmlContent);
                Console.WriteLine("1 console");
            }
        }

        private static void DeserializeXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var reader = new StringReader(xmlString))
            {
                var member = (Member)xmlSerializer.Deserialize(reader);
            }
        }
        // 2 Serialize Object To XmlFile
        private static void SerializeObjectToXmlFile()
        {
            var member = new Member
            {
                Name = "mohamed Hassan",
                Email = "mh0056592@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StreamWriter(@"E:\tit\Tasks\Quiz 1\XmlDemo\sampl01.xml"))
            {
                xmlSerializer.Serialize(writer, member);

            }
        }
        // 3 Serialize List To XmlFile
        private static void SerializeListToXmlFile()
        {
            var memberList = new List<Member>
            {
                new Member
                {
                      Name = "mohamed Hassan",
                Email = "mh0056592@gmail.com",
                Age = 22,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
                },
                new Member
                {
                    Name = "ahmed",
                    Email = "ahmed@gmail.com",
                    Age = 30,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new Member
                {
                    Name = "farouq",
                    Email = "farouq@gmail.com",
                    Age = 22,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new Member
                {
                    Name = "George",
                    Email = "george@gmail.com",
                    Age = 28,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = false
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using (var writer = new StreamWriter(@"E:\tit\Tasks\Quiz 1\XmlDemo\sampl02.xml"))
            {
                xmlSerializer.Serialize(writer, memberList);
            }
        }
        //  XML to List 
        private static void DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using (var reader = new StreamReader(@"E:\tit\Tasks\Quiz 1\XmlDemo\sampl02.xml"))
            {
                var members = (List<Member>)xmlSerializer.Deserialize(reader);

            }
        }

        private static void DeserializeXmlFileToObject()
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var reader = new StreamReader(@"E:\tit\Tasks\Quiz 1\XmlDemo\sampl01.xml"))
            {
                var member = (Member)xmlSerializer.Deserialize(reader);

            }
        }
    }
}
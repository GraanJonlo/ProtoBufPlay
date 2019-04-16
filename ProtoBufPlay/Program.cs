using System;
using System.IO;
using Google.Protobuf;
using ProtoBufPlay.Models;
using static ProtoBufPlay.Models.Person.Types;

namespace ProtoBufPlay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person john = new Person
            {
                Id = 1234,
                Name = "John Doe",
                Email = "jdoe@example.com",
                Phones =
                {
                    new PhoneNumber
                    {
                        Number = "555-4321",
                        Type = PhoneType.Home
                    }
                }
            };

            using (var output = File.Create("john.dat"))
            {
                john.WriteTo(output);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
using System;

namespace Ex2
{
    class Client : Person
    {
        public static string Service { get; set; }
        public static decimal Price { get; set; }
        
        public void InformationAboutClient(params string[] information)
        {
            foreach (var str in information)
                Console.Write($"{str} ");
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} is a client.");
        }
    }
}
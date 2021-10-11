using System;

namespace Ex2
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintPerson(string name)
        {
            Console.WriteLine($"You're: {name}");
        }

        public void PrintPerson(string firstName, string lastName)
        {
            Console.WriteLine($"You're {firstName} {lastName}");
        }

        public void GetPirson()
        {
            Console.Write("\nEnter your first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine($"You're {FirstName} {LastName}");
        }
    }
}
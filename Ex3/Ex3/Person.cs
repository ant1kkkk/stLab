using System;

namespace Ex3
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return ($"{FirstName} {LastName}");
            }
        }

        public string JobTitle { get; set; }
        public decimal JobSalary { get; set; }
        public int id { get; set; }
    }
}
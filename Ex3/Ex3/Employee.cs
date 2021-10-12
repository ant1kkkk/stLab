using System;
using System.Net.Security;

namespace Ex3
{
    public class Employee : IPerson, IDisplayable
    {
        public string JobDescription { get; set; }
        public string Company { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyAddress { get; set; }
        int id { get; set; }

        public void Display()
        {
            Console.WriteLine($"Hello, I am {IPerson.FullName}, {IPerson.JobTitle} in a {CompanyName} ({CompanyCountry}, {CompanyCity}, {CompanyAddress}) and my salary {IPerson.JobSalary}");
        }
    }
}
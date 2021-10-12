using System;

namespace Ex3
{
    public class Employee : Person
    {
        public string JobDescription { get; set; }
        public string Company { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyAddress { get; set; }
    }
}
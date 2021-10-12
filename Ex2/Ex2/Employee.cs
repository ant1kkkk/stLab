using System;

namespace Ex2
{
    class Employee : Person
    {
        public string Specialization { get; set; }
        public int WorkerDay { get; set; }
        public int NumberOfDays { get; set; }
        public decimal SalaryPerHour { get; set; }
        private decimal Salary { get; set; } // Changed public to private access modifier.

        public decimal GetSalary()
        {
            Salary = ((SalaryPerHour - GetDeduction(SalaryPerHour))*WorkerDay) * NumberOfDays;
            return Salary;
        }
        private static decimal GetDeduction(decimal salaryPerHour) // Changed public to private access modifier.
        {
            return (salaryPerHour * 14) / 100;
        }

        public static void InformationAboutEmployee(params string[] information)
        {
            foreach (var str in information)
                Console.Write($"{str} ");
        }
    }
}
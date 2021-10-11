using System;

namespace Ex2
{
    class Employee : Person
    {
        public string Specialization { get; set; }
        public int WorkerDay { get; set; }
        public int NumberOfDays { get; set; }
        public decimal SalaryPerHour { get; set; }
        public decimal Salary { get; set; }

        public decimal GetSalary()
        {
            Salary = ((SalaryPerHour - GetDeduction(SalaryPerHour))*WorkerDay) * NumberOfDays;
            return Salary;
        }
        public static decimal GetDeduction(decimal salaryPerHour)
        {
            return (salaryPerHour * 14) / 100;
        }

        public void InformationAboutEmployee(params string[] information)
        {
            foreach (var str in information)
                Console.Write($"{str} ");
        }
    }
}
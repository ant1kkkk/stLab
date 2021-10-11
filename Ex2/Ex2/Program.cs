using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetPirson();
            Console.Write("Enter your specialization: ");
            employee.Specialization = Console.ReadLine();
            Console.Write("How long is your working day?: ");
            employee.WorkerDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many days in month did you worked?: ");
            employee.NumberOfDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your salary per hour?: ");
            employee.SalaryPerHour = Convert.ToDecimal(Console.ReadLine());
            employee.PrintPerson(employee.FirstName, employee.LastName);
            Console.WriteLine($"Your salary is: {employee.GetSalary()}");
            Console.Write("Short information about employee: ");
            employee.InformationAboutEmployee(employee.FirstName, employee.LastName, employee.Specialization);
            Client client = new Client();
            client.GetPirson();
            Console.Write("Short information about client: ");
            client.InformationAboutClient(client.FirstName, client.LastName);
        }
    }
}
using System;

namespace Ex2
{
    class Program
    {
        private static bool _flag = false;

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    var employee = new Employee();
                    employee.GetPerson();
                    employee.PrintPerson(employee.FirstName, employee.LastName);
                    employee.Display();
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
                    Employee.InformationAboutEmployee(employee.FirstName, employee.LastName, employee.Specialization);
                    var client = new Client();
                    client.GetPerson();
                    client.PrintPerson(client.FirstName);
                    client.Display();
                    Console.Write("Short information about client: ");
                    client.InformationAboutClient(client.FirstName, client.LastName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input try again");
                    _flag = true;
                }
            } while (_flag == true);
        }
    }
}
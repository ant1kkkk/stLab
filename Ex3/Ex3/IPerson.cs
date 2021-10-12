namespace Ex3
{
    public interface IPerson
    {
        static string FirstName { get; set; }
        static string LastName { get; set; }

        static string FullName
        {
            get
            {
                return ($"{FirstName} {LastName}");
            }
        }

        static string JobTitle { get; set; }
        static string JobDescription { get; set; }
        static decimal JobSalary { get; set; }
    }
}
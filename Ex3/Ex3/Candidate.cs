using System;

namespace Ex3
{
    public class Candidate : IDisplayable, IPerson
    {
        int id { get; set; }
        private enum DismissalReason
        {
            FamilyReasons = 1,
            ProfessionalGrowthLack = 2,
            LowSalary = 3,
            BadTeamMicroclimate = 4,
            LackManagementUnderstanding = 5,
            Other = 6,
            NotWorked = 0
        }

        public static string DismissalReasons()
        {
            string dismissalReasons = Console.ReadLine();
            DismissalReason dismissalReason =
                (DismissalReason) Enum.Parse(typeof(DismissalReason), dismissalReasons, ignoreCase: true);
            string dismissalReasonOut;
            switch (dismissalReason)
            {
                case DismissalReason.FamilyReasons:
                    dismissalReasonOut = "Family reasons";
                    break;
                case DismissalReason.ProfessionalGrowthLack:
                    dismissalReasonOut = "Professional growth lack";
                    break;
                case DismissalReason.LowSalary:
                    dismissalReasonOut = "Low salary";
                    break;
                case DismissalReason.BadTeamMicroclimate:
                    dismissalReasonOut = "Bad team microclimate";
                    break;
                case DismissalReason.LackManagementUnderstanding:
                    dismissalReasonOut = "Lack management understanding";
                    break;
                case DismissalReason.Other:
                    dismissalReasonOut = "Other";
                    break;
                case DismissalReason.NotWorked:
                    dismissalReasonOut = null;
                    break;
                default:
                    dismissalReasonOut = "null";
                    break;
            }
            
            return dismissalReasonOut;
        }

        public void Display()
        {
            if (DismissalReasons() != null)
            {
                Console.WriteLine(
                    $"Hello, I am {IPerson.FullName}.\nI want to be a {IPerson.JobTitle} ({IPerson.JobDescription}) with a salary from {IPerson.JobSalary}.\nI quit my previous job for a reason of {DismissalReasons()}");
            }
            else
            {
                Console.WriteLine($"Hello, I am {IPerson.FullName}.\nI want to be a {IPerson.JobTitle} ({IPerson.JobDescription}) with a salary from {IPerson.JobSalary}.\nI haven't worked anywhere before");
            }
        }
    }
}
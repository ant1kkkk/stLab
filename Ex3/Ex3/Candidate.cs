using System;

namespace Ex3
{
    public class Candidate : Person
    {
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

        public static void DismissalReasons()
        {
            string dismissalReasons = Console.ReadLine();
            DismissalReason dismissalReason =
                (DismissalReason) Enum.Parse(typeof(DismissalReason), dismissalReasons, ignoreCase: true);
            switch (dismissalReason)
            {
                case DismissalReason.FamilyReasons:
                    Console.WriteLine("Family Reasons");
                    break;
                case DismissalReason.ProfessionalGrowthLack:
                    Console.WriteLine("Professional growth lack");
                    break;
                case DismissalReason.BadTeamMicroclimate:
                    Console.WriteLine("Bad team microclimate");
                    break;
                case DismissalReason.LackManagementUnderstanding:
                    Console.WriteLine("Lack management understanding");
                    break;
                case DismissalReason.Other:
                    Console.WriteLine("Other");
                    break;
                case DismissalReason.NotWorked:
                    Console.WriteLine($"{null}");
                    break;
            }
        }
    }
}
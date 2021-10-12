using System;

namespace Ex3
{
    public class Candidate : Person
    {
        public enum DismissalReason
        {
            FamilyReasons = 1,
            ProfessionalGrowthLack = 2,
            LowSalary = 3,
            BadTeamMicroclimate = 4,
            LackManagementUnderstanding = 5,
            other = 6,
            NotWorked = 0
        }

        public static void DismissalReasons()
        {
            string[] dismissalReasons =
            {
                "1", "2", "3", "4", "5", "6", "0", /*"Family reasons", "Professional growth lack", "Low salary",
                "Bad team microclimate",
                "Lack management understanding", "other", "null"*/
            };
            foreach (string dismissalReason in dismissalReasons)
            {
                DismissalReason dismissalReasonValue =
                    (DismissalReason) Enum.Parse(typeof(DismissalReason), dismissalReason);
                Console.WriteLine($"{dismissalReasonValue.ToString()}");
            }

            //DismissalReason dismissalReasonFamilyReasons;
            //dismissalReasonFamilyReasons = (DismissalReason) Enum.Parse(typeof(DismissalReason), dismissalReasons[0]);
            string[] allReasons = {"Family reasons", "Professional growth lack", "Low salary",
                "Bad team microclimate",
                "Lack management understanding", "other", null};
            string dis = DismissalReason.FamilyReasons.ToString();
            dis = allReasons[0];
            Console.WriteLine(dis);
        }
    }
}
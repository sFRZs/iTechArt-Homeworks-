using System;

namespace Task1.User.Classes
{
    public class Candidate : User
    {
        private string _dismissalReason;

        public Candidate()
        {
            Random rnd = new Random();
            
            // Выбираем случайным образом причину увольнения
            _dismissalReason = Convert.ToString((ReasonForDismissal) rnd.Next(0, 7));
        }

        public override void Display()
        {
            Console.WriteLine($"Hello, I am {FullName}. \nI want to be a {JobTitle} ({JobDescription}) with a salary from ${JobSalary}.");
            Console.WriteLine(_dismissalReason == Convert.ToString(ReasonForDismissal.Null) ? "I haven't worked anywhere before." : $"I quit my previous job for a reason of {_dismissalReason}.");
        }
    }

    enum ReasonForDismissal
    {
        FamilyReasons,
        ProfessionalGrowthLack,
        LowSalary,
        BadTeamMicroclimate,
        LackManagementUnderstanding,
        Other,
        Null
    }
}
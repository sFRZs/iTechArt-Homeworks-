using System;
using System.Collections.Generic;
using Task1.ReportGenerator.Classes;
using Task1.User.Classes;
using Task1.User.Classes.Employee;

// enum  Users
// {
//     Candidate,
//     Employee
// }

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = {"Employee",  "Candidate"};

        Random rnd = new Random();
            int maxValueOfUsers = rnd.Next(30);

            var employees = new List<Employee>();
            var candidates = new List<Candidate>();
            var userFactory = new UserFactory();

            for (int i = 0; i < maxValueOfUsers; i++)
            {
                userFactory.GenerateUser(/*Convert.ToString((Users)*/ users[rnd.Next(2)]/*)*/, employees, candidates);
            }

            foreach (var user in employees)
            {
                user.Display();
                Console.WriteLine();
            }

            foreach (var user in candidates)
            {
                user.Display();
                Console.WriteLine();
            }

            var erg = new EmployeeReportGenerator();
            erg.SortEmployee(employees);

            var crg = new CandidateReportGenerator();
            crg.SortCandidate(candidates);
        }
    }
}
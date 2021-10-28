using System;
using System.Collections.Generic;
using Bogus;

namespace Task1.User.Classes
{
    public class UserFactory
    {
        public void GenerateUser(string user, List<Employee.Employee> employees, List<Candidate> candidates)
        {
            if (user == "Employee")
            {
                CreateUser<Employee.Employee>(employees);
            }

            if (user == "Candidate")
            {
                CreateUser<Candidate>(candidates);
            }
        }

        private void CreateUser<T>(List<T> users) where T : User
        {
            var faker = new Faker<T>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.JobTitle, f => f.Name.JobTitle())
                .RuleFor(c => c.JobDescription, f => f.Name.JobDescriptor())
                .RuleFor(c => c.JobSalary, f => f.Finance.Amount(50m, 10000m));
            users.Add(faker.Generate());
        }
    }
}
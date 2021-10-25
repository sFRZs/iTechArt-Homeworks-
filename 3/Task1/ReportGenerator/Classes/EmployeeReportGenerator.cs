using System;
using System.Collections.Generic;
using Task1.ReportGenerator.Interfaces;
using Task1.User.Classes.Employee;

namespace Task1.ReportGenerator.Classes
{
    public class EmployeeReportGenerator : IReportGenerator
    {
        public void SortEmployee(List<Employee> employees)
        {
            var users = new List<object>();
            for (int i = 0; i < employees.Count; i++)
            {
                users.Add(employees[i]);
            }

            SortUser(users);
        }

        public void SortUser(List<object> users)
        {
            var employees = new List<Employee>();
            for (int i = 0; i < users.Count; i++)
            {
                employees.Add((Employee) users[i]);
            }

            // Сортируем по названию компании.
            employees.Sort((a, b) => a.company.Name.CompareTo(b.company.Name));
            
            // Сортируем по з/п, если названия компаний совпадают.
            for (int i = 0; i < employees.Count; i++)
            {
                var tmp = new Employee();

                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (j == employees.Count)
                    {
                        break;
                    }

                    if (employees[i].company.Name.Equals(employees[j].company.Name))
                    {
                        if (employees[i].JobSalary < employees[j].JobSalary)
                        {
                            tmp = employees[i];
                            employees[i] = employees[j];
                            employees[j] = tmp;
                            tmp = null;
                        }
                    }
                }
            }

            Console.WriteLine("\nSorted Employees:");
            foreach (var user in employees)
            {
                Console.WriteLine($"{user.Id} | {user.company.Name,40} | {user.FullName,25} | ${user.JobSalary}");
            }
        }
    }
}
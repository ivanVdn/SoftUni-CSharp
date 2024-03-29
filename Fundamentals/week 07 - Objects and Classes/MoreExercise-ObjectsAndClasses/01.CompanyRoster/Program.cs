using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }

    internal class Program
    {
        internal static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var employeesByDepartment = new Dictionary<string, List<Employee>>();

            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var department = input[2];

                if (!employeesByDepartment.ContainsKey(department))
                {
                    employeesByDepartment[department] = new List<Employee>();
                }

                employeesByDepartment[department].Add(new Employee(name, salary, department));
            }

            var departmentWithHighestSalary = employeesByDepartment.MaxBy(kv => kv.Value.Average(e => e.Salary));

            Console.WriteLine($"Highest Average Salary: {departmentWithHighestSalary.Key}");

            foreach (var employee in departmentWithHighestSalary.Value.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
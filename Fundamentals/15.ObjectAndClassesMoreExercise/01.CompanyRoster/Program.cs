using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                decimal salary = decimal.Parse(parts[1]);
                string department = parts[2];

                if (!departments.Any(d => d.DepartmentName == department))
                {
                    departments.Add(new Department(department));
                }

                departments.Find(d => d.DepartmentName == department).AddNewEmployee(name, salary);
            }

            Department departmentWithHighestSalary = departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count).First();

            Console.WriteLine($"Highest Average Salary: {departmentWithHighestSalary.DepartmentName}");

            foreach (var employee in departmentWithHighestSalary.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee);
            }
        }

        class Employee
        {
            public Employee(string name,decimal salary)
            {
                this.Name = name;
                this.Salary = salary;
            }
            public string Name { get; set; }
            public decimal Salary { get; set; }

            public override string ToString()
            {
                return $"{this.Name} {this.Salary:f2}";
            }
        }

        class Department
        {
            public Department(string departmentName)
            {
                this.Name = departmentName;
            }
            public string Name { get; set; }
            public List<Employee> Employees { get; set; } = new List<Employee>();
            public decimal TotalSalaries { get; set; }

            public void AddNewEmployee(string name, decimal salary)
            {
                this.TotalSalaries += salary;

                this.Employees.Add(new Employee(name, salary));
            }

        }
    }
}

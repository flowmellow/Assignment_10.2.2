/*
2. Write a program to create a list of employees. Consider a hard coded list. Display all employees who have salary more than $5000 and age < 30.
*/

using System.Security.Cryptography.X509Certificates;

namespace Assignment_10._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> Employees = new List<Employee>()
            {
                new Employee() { FirstName = "Mike", LastName = "Flores", Age = 25, Salary = 195000.00 },
                new Employee() { FirstName = "John", LastName = "Lucas", Age = 25, Salary = 4500.00 },
                new Employee() { FirstName = "Esmeralda", LastName = "Esteban", Age = 29, Salary = 85000.00 },
                new Employee() { FirstName = "Arnold", LastName = "Palmer", Age = 30, Salary = 100000.00 },
                new Employee() { FirstName = "Lenny", LastName = "Justice", Age = 25, Salary = 75000.00 },
                new Employee() { FirstName = "Paris", LastName = "Hilton", Age = 25, Salary = 13000.00 },
                new Employee() { FirstName = "Vera", LastName = "Wang", Age = 90, Salary = 2002105000.00 }
            };

            var employeeQuery = from employee in Employees
                                where employee.Salary > 5000 && employee.Age < 30 
                                select employee;

            Console.WriteLine("Our staff with a salary of more than $5000 and under the age of 30.");
            foreach (var employee in employeeQuery)
            {
                Console.WriteLine($"{employee.FirstName}, {employee.LastName}, {employee.Age}, ${employee.Salary}");
            }
            Console.WriteLine();

            var restEmployeeQuery = from employee in Employees
                                     where employee.Salary > 5000 && employee.Age >= 30
                                     select employee;

            Console.WriteLine("Our staff with a salary of more than 5000 and at or over the age of 30.");
            foreach (var employee in restEmployeeQuery)
            {
                Console.WriteLine($"{employee.FirstName}, {employee.LastName}, {employee.Age}, ${employee.Salary}");
            }
        }


    }

    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}

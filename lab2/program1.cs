using System;

namespace EmployeeDemo
{
    // Employee class definition
    public class Employee
    {
        // Fields
        private string name;
        private string email;
        private decimal salary;

        // Constructor to initialize the employee
        public Employee(string name, string email, decimal salary)
        {
            this.name = name;
            this.email = email;
            this.salary = salary;
        }

        // Properties to access and modify private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Method to display employee details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}"); // :C formats the salary as currency
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an Employee object
            Employee emp = new Employee("khushbu sah", "alice.khushi@example.com", 75000.00m);

            // Displaying employee information
            emp.DisplayInfo();

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

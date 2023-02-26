using System;
using System.Collections.Generic;

namespace Methods
{
    class RetiredEmployee : Employee
    {
        public int MonthlySalary()
        {
            return 0;
        }
    }

    class Employee
    {
        public Employee()
        {
            this.CreatedAt = DateTime.Now;
        }
        public string Name { get; set; }
        public int Department { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Salary { get; set; }
        public int MonthlySalary()
        {
            return Salary / 12;
        }

        // public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
        // {
        //     Name = newName;
        //     Department = newDepartment;
        //     Salary = newSalary;
        //     MonthlySalary = newMonthlySalary;
        // }
    }

    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Employee Database    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.WriteLine("🚀🚀🚀🚀");
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            var userInput = PromptForString(prompt);
            int inputAsInteger;
            var isThisGoodInput = int.TryParse(userInput, out inputAsInteger);
            if (isThisGoodInput)
            {
                return inputAsInteger;
            }
            else
            {
                Console.WriteLine("That isn't an integer. You get a 0");
                return 0;
            }
        }

        static int ComputeMonthlySalaryFromYearly(int yearlySalary)
        {
            return yearlySalary / 12;
        }

        static void Main(string[] args)
        {
            // var graceHopper = new Employee("Grace Hopper", 100, 240_000, 24_000);
            // Console.WriteLine(graceHopper.Department);

            // var elliotPage = new Employee("Elliot Page", 42, 120_000, 12_000);
            // Console.WriteLine(elliotPage.Department);

            // var employees = new List<Employee>();
            // employees.Add(graceHopper);
            // employees.Add(elliotPage);

            // var firstEmployee = new Employee();
            // var secondEmployee = new Employee();

            // firstEmployee.Name = "Elliot Page";
            // firstEmployee.Department = 42;
            // firstEmployee.Salary = 120000;
            // firstEmployee.MonthlySalary = 10000;

            // secondEmployee.Name = "Grace Hopper";
            // secondEmployee.Department = 100;
            // secondEmployee.Salary = 240000;
            // secondEmployee.MonthlySalary = 20000;




            var employee = new Employee();

            var thirdEmployee = new RetiredEmployee
            {
                Name = "Bill Gates",
                Department = 101,
                Salary = 120,
            };

            Console.WriteLine(thirdEmployee.MonthlySalary());

            DisplayGreeting();

            employee.Name = PromptForString("What is your name? ");
            employee.Department = PromptForInteger("What is your department number?");
            employee.Salary = PromptForInteger("What is your yearly salary (in dollars)?");
            // employee.MonthlySalary();

            Console.WriteLine($"Hello, {employee.Name} you make {employee.MonthlySalary()} dollars per month.");
        }
    }
}


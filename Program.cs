using System;
using System.Collections.Generic;

namespace Methods
{
    class Employee
    {
        public string Name;
        public int Department;
        public int Salary;
        public int MonthlySalary;

        public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
        {
            Name = newName;
            Department = newDepartment;
            Salary = newSalary;
            MonthlySalary = newMonthlySalary;
        }
    }

    class Program
    {
        static void DisplayGreeting()
        {
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
            var graceHopper = new Employee("Grace Hopper", 100, 240_000, 24_000);
            Console.WriteLine(graceHopper.Department);

            var elliotPage = new Employee("Elliot Page", 42, 120_000, 12_000);
            Console.WriteLine(elliotPage.Department);

            var employees = new List<Employee>();
            employees.Add(graceHopper);
            employees.Add(elliotPage);


            DisplayGreeting();

            var name = PromptForString("What is your name? ");

            var department = PromptForInteger("What is your department number?");

            var salary = PromptForInteger("What is your yearly salary (in dollars)?");

            var salaryPerMonth = ComputeMonthlySalaryFromYearly(salary);

            Console.WriteLine($"Hello, {name} you make {salaryPerMonth} dollars per month.");
        }
    }
}


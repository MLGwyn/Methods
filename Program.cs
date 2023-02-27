using System;
using System.Collections.Generic;

namespace Methods
{
    class Employee
    {
        public string Name { get; set; }
        public int Department { get; set; }
        public int Salary { get; set; }
        public int MonthlySalary()
        {
            int ComputedMonthlySalary = Salary / 12;
            return MonthlySalary();
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

        // static int ComputedMonthlySalary(int yearlySalary)
        // {
        //     return yearlySalary / 12;
        // }

        static void Main(string[] args)
        {
            // var graceHopper = new Employee("Grace Hopper", 100, 240_000, 24_000);
            // Console.WriteLine(graceHopper.Department);

            // var elliotPage = new Employee("Elliot Page", 42, 120_000, 12_000);
            // Console.WriteLine(elliotPage.Department);

            // var employees = new List<Employee>();
            // employees.Add(graceHopper);
            // employees.Add(elliotPage);


            var elliotPage = new Employee()
            {
                Name = "Elliot Page",
                Department = 42,
                Salary = 120000,
                // MonthlySalary = 10000
            };

            var graceHopper = new Employee();
            graceHopper.Name = "Grace Hopper";
            graceHopper.Department = 100;
            graceHopper.Salary = 240000;
            // graceHopper.MonthlySalary = 20000;

            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Name = "Melissa Gwyn",
                },

                new Employee()
                {
                    Name = "Ducky Orlando"
                }
            };

            employees[0].Department = 500;


            employees.Add(graceHopper);
            employees.Add(elliotPage);

            employees[1].Department = 6969;

            Console.WriteLine($"You have {employees.Count} employees. ");
            Console.WriteLine($"Ducky is in department {employees[1].Department}");





            DisplayGreeting();

            var employeeList = new List<Employee>();

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine();
                Console.WriteLine($"----- You have {employeeList.Count} employees ----- ");
                Console.WriteLine();

                var name = PromptForString("What is your name? ");
                var department = PromptForInteger("What is your department number?");
                var salary = PromptForInteger("What is your yearly salary (in dollars)?");
                // var monthlySalary = ComputedMonthlySalary(salary);

                // Console.WriteLine($"Hello, {name} you make {monthlySalary} dollars per month.");

                var newEmployee = new Employee();
                newEmployee.Name = name;
                newEmployee.Department = department;
                newEmployee.Salary = salary;
                // newEmployee.MonthlySalary = monthlySalary;

                Console.WriteLine($"By the way their monthly salary is {newEmployee.MonthlySalary()}");
                employeeList.Add(newEmployee);

                var answer = PromptForString("Keep going? ");
                if (answer.ToLower() == "no")
                {
                    keepGoing = false;
                }


                // Console.WriteLine($"Your employees are {}. ");
            }
        }
    }
}


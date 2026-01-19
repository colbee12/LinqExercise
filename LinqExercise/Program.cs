using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your gitHub when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("sum of numbers: ");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("avrage of numbers: ");
            Console.WriteLine(numbers.Average()); 
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("numbers in ascending order:");
            var ascending = numbers.OrderBy(x => x).ToArray();
            foreach (var num in ascending)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("numbers in descending order:");
            var descending = numbers.OrderByDescending(x => x).ToArray();
            foreach (var num in descending)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("numbers above six");
            var numbersAboveSIx = numbers.Where(x => x > 6).ToArray();
            foreach (var num in numbersAboveSIx)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("only 4 numbers");
            foreach (var item in numbers.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("changed the value of index four to 20");
            numbers.SetValue(20, 4);
            foreach(var num in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(num);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("names that start with c or s");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S"))
                .OrderBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("employees that are older than 26");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"FullName: {x.FullName}, Age: {x.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of years of experience:");
            var employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine();
            
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Average of years of experience:");
            var employeeAverage = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAverage);
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Colbee";
            newEmployee.LastName = "Thrasher";
            newEmployee.Age = 20;
            newEmployee.YearsOfExperience = 2;
            
            employees = employees.Concat(new[] { newEmployee }).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }
            
            


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

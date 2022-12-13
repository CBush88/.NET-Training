using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create one class for getting information of employees, like employee name, designation and salary
//Create another class for displaying the information of employee and calculate the
//bonus on employee's salary and display

namespace Week2Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = ' ';
            while (input != 'n')
            {
                Console.Write("Enter Employee Name: ");
                string empName = Console.ReadLine();

                Console.Write("Enter Employee position: ");
                string position = Console.ReadLine();

                Console.Write("Enter Employee Salary: ");
                int salary = int.Parse(Console.ReadLine());

                Employee emp = new Employee(empName, position, salary);

                emp.Show();
                emp.getBonus();

                Console.WriteLine("Do you have another employee? (y/n)");
                input = Console.ReadLine().ToLower()[0];
            }
        }
    }
}

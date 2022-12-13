using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment1
{
    internal class Employee: IShow, IBonus
    {
        string name;
        string position;
        int salary;
        double bonusMulti = .07;
        public Employee(string name, string position, int salary) 
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }
        public void Show()
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Position: {position}");
            Console.WriteLine($"Employee Salary: {salary}");
        }
        public void getBonus()
        {
            Console.WriteLine($"Employee Bonus is {bonusMulti * salary}");
        }
    }
}

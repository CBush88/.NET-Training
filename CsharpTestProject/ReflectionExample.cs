using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CsharpTestProject
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public Employee()
        {
            EmpId = -1;
            Name = string.Empty;
            Salary = 0;
        }
        public Employee(int empId, string name, float salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }

        public void DisplayName()
        {
            Console.WriteLine("Name: " + Name);
        }
        public void DisplayEmp(string name)
        {
            Console.WriteLine("Name: " + name);
        }
        public void PrintSalary()
        {
            Console.WriteLine("Salary: " + Salary);
        }
    }
    internal class ReflectionExample
    {
        static void Main(string[] args)
        {
            Assembly executable = Assembly.GetExecutingAssembly();
            Type Ltype = executable.GetType("CsharpTestProject.Employee");

            object objEmployee = Activator.CreateInstance(Ltype);
            MethodInfo method = Ltype.GetMethod("DisplayEmp");
            string[] parameter = new string[1];
            parameter[0] = "Chris";
            string employeeName = (string)method.Invoke(objEmployee, parameter);
            Console.ReadKey();
        }
    }
}

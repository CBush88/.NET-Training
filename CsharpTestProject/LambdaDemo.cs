using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CsharpTestProject
{
    internal class LambdaDemo
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Designation { get; set; }
            public int Salary { get; set; }

            public Employee(string name, string designation, int salary)
            {
                Name = name;
                Designation = designation;
                Salary = salary;
            }
        }
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x=> x%2 == 0); //Simple lambda expression for getting even numbers from existing object type

            List<int> testList = new List<int>();

            list.ForEach(x => testList.Add(x*x));

            foreach(int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            foreach(int num in testList)
            {
                Console.WriteLine(num);
            }

            List<Dog> dogs = new List<Dog>(){
                new Dog{Name = "Rex", Age = 4 },
                new Dog{Name = "Sean", Age = 1},
                new Dog{Name = "Stacy", Age = 3}
            };

            var names = dogs.Select(x => x.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var newDogList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            foreach(var item in newDogList)
            {
                Console.WriteLine(item);
            }

            //Sorting the age of the dogs by descending order

            var sortedDogs = dogs.OrderByDescending(x => x.Age);

            foreach(var dog in sortedDogs)
            {
                Console.WriteLine(dog.Name);
            }




            Employee emp1 = new Employee("Bob", "Junior", 3500);
            Employee emp2 = new Employee("Nick", "Senior", 5200);
            Employee emp3 = new Employee("John", "Manager", 5700);

            List<Employee> employees = new List<Employee> { emp1, emp2, emp3 };

            List<Employee> sortedByName = employees.OrderBy(x => x.Name).ToList();

            List<Employee> over5000 = employees.FindAll(x => x.Salary >= 5000);

            ArrayList bonusList = new ArrayList();

            employees.ForEach(x => bonusList.Add(new { Name = x.Name, Bonus = x.Salary * .05 }));

            Console.WriteLine("Employees");
            foreach(Employee emp in employees)
            {
                Console.WriteLine($"Name: {emp.Name} Designation: {emp.Designation} Salary: {emp.Salary}");
            }

            Console.WriteLine("\nSorted");
            foreach(Employee emp in sortedByName)
            {
                Console.WriteLine($"Name: {emp.Name} Designation: {emp.Designation} Salary: {emp.Salary}");
            }

            Console.WriteLine("\nOver 5000 Salary");
            foreach(Employee emp in over5000)
            {
                Console.WriteLine($"Name: {emp.Name} Designation: {emp.Designation} Salary: {emp.Salary}");
            }

            Console.WriteLine("\nBonus Calc");
            foreach(var emp in bonusList)
            {
                Console.WriteLine(emp);
            }
            Console.ReadKey();
        }
    }
}

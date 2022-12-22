using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class EmployeData
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }
    }
    internal class LINQtoObjectsDemo
    {
        static void Main(string[] args)
        {
            //Create object of class and create list of employees
            List<EmployeData> objEmp = new List<EmployeData>()
            {
                new EmployeData{EmpId = 1, EmpName = "Chris", Location = "Work"},
                new EmployeData{EmpId = 2, EmpName = "Bob", Location = "Home"},
                new EmployeData{EmpId = 3, EmpName = "Sara", Location = "Canada"},
                new EmployeData{EmpId = 4, EmpName = "John", Location = "Florida"},
                new EmployeData{EmpId = 5, EmpName = "Richard", Location = "Georgia"}
            };

            //var result = from e in objEmp
            //             where e.Location.Equals("Florida")
            //             select new {Name = e.EmpName, Location = e.Location};

            Console.WriteLine("Employee data after filter operation");

            //foreach(var item in result)
            //{
            //    Console.WriteLine("Name: " + item.Name + "\tLocation: " + item.Location);
            //}

            var result1 = objEmp.Where(e => e.Location.Equals("Florida")).Select(e => new {Name = e.EmpName, Location = e.Location}).ToList();
            result1.ForEach(e => Console.WriteLine("Name: " + e.Name + "\tLocation: " + e.Location));

            var result2 = objEmp.OrderBy(e => e.Location).ToList();
            result2.ForEach(e => Console.WriteLine(e.EmpName + "\t" + e.Location));

            var groupings = objEmp.GroupBy(e => e.Location.Length).ToList();

            //foreach (var group in groupings)
            //{
            //    foreach (var emp in group)
            //    {
            //        Console.Write(emp.EmpName + " Location: " + emp.Location + "\t");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine();

            groupings.ForEach(group => {
                group.ToList()
                .ForEach(emp => Console.WriteLine(emp.EmpName + " Location: " + emp.Location + "\t"));
                Console.WriteLine();
            });
        }
    }
}

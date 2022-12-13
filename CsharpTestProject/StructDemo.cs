using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class StructDemo
    {
        public struct Student
        {
            public int id;
            public string name;
            public string course;
        };

        public struct Fruit
        {
            public int upc;
            public string name;
            public string description;

            public override string ToString()
            {
                return "{\nupc: " + upc + "\nname: " + name + "\ndescription " + description + "\n}";
            }
        }        
        static void Main(string[] args)
        {
            Student s; //create a struct on stack
            s.id = 101;
            s.name = "Alex";
            s.course = ".Net";

            //access the fields of struct
            Console.WriteLine($"Student id: {s.id}");
            Console.WriteLine($"Student name: {s.name}");
            Console.WriteLine($"student course: {s.course}");

            Fruit f;
            f.upc = 1;
            f.name = "Banana";
            f.description = "A yellow fruit with a peel";

            Console.WriteLine("UPC: " + f.upc);
            Console.WriteLine("Name: " + f.name);
            Console.WriteLine("Description: " + f.description);
            Console.WriteLine(f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice_InheritanceAndStaticMethods
{
    class Person
    {
        public static int people = 0;

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string phoneno { get; set; }
        public char gender { get; set; }

        public Person(int id, string name, int age, string address, string phoneno, char gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phoneno = phoneno;
            this.gender = gender;

            people++;
        }
        public Person() 
        {
            people++;
        }
    }
    class Student: Person
    {
        public string course { get; set; }
        public double grade { get; set; }
        public long regno { get; }

        static long regnoSeq = 2022060001;

        public static int students = 0;

        public Student (string course, double grade)
        {
            this.course = course;
            this.grade = grade;
            this.regno = regnoSeq++;
            students++;
        }

        public Student (int id, string name, int age, string address, string phoneno,
            char gender, string course, double grade):base(id, name, age, address, phoneno, gender)
        {
            this.course = course;
            this.grade = grade;
            this.regno = regnoSeq++;
            students++;
        }

        public Student() 
        {
            regnoSeq++;
            students++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1, "John", 20, "101 fake street", "123-456-7890", 'm');
            Person p2 = new Person(2, "James", 22, "102 fake street", "234-567-8901", 'm');

            Student s1 = new Student(3, "Bob", 21, "103 fake street", "345-678-9012", 'm', ".NET", 96.5);
            Student s2 = new Student(4, "Liz", 22, "104 fake street", "456-789-0123", 'f', "Java", 92.1);

            Console.WriteLine(p1.id + " " + p1.name + " " + p1.address + " " + p1.phoneno + " " + p1.gender);
            Console.WriteLine(p2.id + " " + p2.name + " " + p2.address + " " + p2.phoneno + " " + p2.gender);

            Console.WriteLine();

            Console.WriteLine(s1.id + " " + s1.name + " " + s1.address + " " + s1.phoneno + " " + s1.gender
                + " " + s1.course + " " + s1.grade + " " + s1.regno);
            Console.WriteLine(s2.id + " " + s2.name + " " + s2.address + " " + s2.phoneno + " " + s2.gender
                + " " + s2.course + " " + s2.grade + " " + s2.regno);

            Console.WriteLine();

            Console.WriteLine(Person.people + " people created.");
            Console.WriteLine(Student.students + " students created.");


        }
    }
}

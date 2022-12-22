using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignment_FunctionalProgramming
{
    public enum Gender
    {
        Male, Female, No_Response
    }
    public class Applicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double GPA { get; set; }

        public Applicant(string firstName, string lastName, int age, Gender gender, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName} \nLast Name: {LastName} \nAge: {Age} " +
                $"\nGender: {Gender} \nGPA: {GPA}";
        }
    }
}

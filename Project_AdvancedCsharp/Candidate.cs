using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AdvancedCsharp
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Qualification { get; set; }
        public string Major { get; set; }
        public float GPA { get; set; }
        public string BloodGroup { get; set; }
        public string DateOfBirth { get; set; }

        public Candidate()
        {
            Name = string.Empty;
            Id = -1;
            Address = string.Empty;
            PhoneNumber = string.Empty;
            Qualification = string.Empty;
            Major = string.Empty;
            GPA = 0.0f;
            BloodGroup = string.Empty;
            DateOfBirth = string.Empty;
        }
        public Candidate(string name, int id, string address, string phoneNumber, string qualification,
            string major, float gpa, string bloodGroup, string dateOfBirth)
        {
            if (name.Length < 3)
            {
                throw new NameException("Name Exception: Name should be at least 3 characters!");
            }
            else if (id < 100 || id > 10000)
            {
                throw new IdException("Id Exception: Ids start at 100 and are less than 10000!");
            }
            Name = name;
            Id = id;
            Address = address;
            PhoneNumber = phoneNumber;
            Qualification = qualification;
            Major = major;
            GPA = gpa;
            BloodGroup = bloodGroup;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nId: {Id}\nAddress: {Address}\nPhone Number: {PhoneNumber}\nQualification: {Qualification}"
                + $"\nMajor: {Major}\nGPA: {GPA}\nBlood Group: {BloodGroup}\nDateOfBirth: {DateOfBirth}";
        }
    }
    public class NameException : Exception
    {
        public NameException(string message) : base(message) { }
    }
    public class IdException : Exception
    {
        public IdException(string message) : base(message) { }
    }
}

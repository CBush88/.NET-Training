using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgrammingPractice_EF_CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public string DeptName { get; set; }

        public Nullable<int> DeptId { get; set; }
        public virtual Dept Department { get; set; }

        public string CourseName { get; set; }
        public Nullable<int> CourseId { get; set; }
        public virtual Course Course { get; set;}
    }
}
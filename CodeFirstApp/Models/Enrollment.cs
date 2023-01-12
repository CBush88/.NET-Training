using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } //Nullable
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
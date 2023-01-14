using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgrammingPractice_EF_CodeFirst.Models
{
    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptNumber { get; set; }
        public string Location { get; set; }
        public string Head { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
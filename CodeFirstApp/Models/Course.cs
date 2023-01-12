using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //allow user input of CourseId
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
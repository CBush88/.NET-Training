using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgrammingPractice_EF_CodeFirst.Models
{
    public enum Type
    {
        Programming, Database, Designing, Server_Client_Architecture
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string RequiredQualification { get; set; }

        //[Column(TypeName = "varchar(50)")] Does not work
        public Type Type { get; set; }

        public Nullable<int> DeptId { get; set; }
        public virtual Dept Department { get; set; }
    }
}
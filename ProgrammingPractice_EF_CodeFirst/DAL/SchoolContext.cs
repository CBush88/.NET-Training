using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using ProgrammingPractice_EF_CodeFirst.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection.Emit;

namespace ProgrammingPractice_EF_CodeFirst.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolContext")
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<GradeCriteria> GradeCriteria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
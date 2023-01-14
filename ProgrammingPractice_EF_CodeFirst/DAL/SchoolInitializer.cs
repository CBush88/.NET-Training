using ProgrammingPractice_EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingPractice_EF_CodeFirst.DAL
{
    public class SchoolInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var depts = new List<Dept>
            {
                new Dept{Id = 1, Name = "Computer Science", DeptNumber = 101, Head = "Rob Robertson", Location = "Main Building"},
                new Dept{Id = 2, Name = "Design", DeptNumber = 102, Head = "Will Wilson", Location = "Annex"}
            };
            depts.ForEach(d => context.Depts.Add(d));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{Id = 1, Name = ".NET", Duration = "3 Month", RequiredQualification = "BS", Type = Models.Type.Programming, DeptId=1},
                new Course{Id = 2, Name = "Cloud Infrastructure", Duration = "6 weeks", RequiredQualification = "AS", Type= Models.Type.Server_Client_Architecture, DeptId=1},
                new Course{Id = 3, Name = "Intuitive Design", Duration = "6 weeks", RequiredQualification = "BA", Type = Models.Type.Designing, DeptId = 1},
                new Course{Id = 4, Name = "Database Fundamentals", Duration = "6 weeks", RequiredQualification = "AS", Type = Models.Type.Database, DeptId = 2}
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var gradecriteria = new List<GradeCriteria>
            {
                new GradeCriteria{Id = 1, GradeName = "A", MinPercentage = 90, MaxPercentage = 100 },
                new GradeCriteria{Id = 2, GradeName = "B", MinPercentage = 80, MaxPercentage = 89},
                new GradeCriteria{Id = 3, GradeName = "C", MinPercentage = 70, MaxPercentage = 79},
                new GradeCriteria{Id = 4, GradeName = "D", MinPercentage = 60, MaxPercentage = 69},
                new GradeCriteria{Id = 5, GradeName = "F", MinPercentage = 0, MaxPercentage = 59}
            };
            gradecriteria.ForEach(g => context.GradeCriteria.Add(g));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{Id = 1, Name = "Bob Bobson", Address = "123 fake street",
                    City = "Metropolis", State = "New York", Country = "US",
                    DateOfBirth = new DateTime(2000, 10, 13), RegistrationNumber = 1,
                    PhoneNumber = "1234567890", CourseId = 1, CourseName = ".NET", DeptId = 1, DeptName = "Computer Science"},
                new Student{Id = 2, Name = "James Jameson", Address = "124 fake street",
                    City = "Gotham", State = "New York", Country = "US",
                    DateOfBirth = new DateTime(2000, 8, 24), RegistrationNumber = 2,
                    PhoneNumber = "1345678902", CourseId = 3, CourseName = "Intuitive Design", DeptId = 2, DeptName = "Design"},
            };
            students.ForEach(s => context.Students.Add(s));

            context.SaveChanges();
        }
    }
}
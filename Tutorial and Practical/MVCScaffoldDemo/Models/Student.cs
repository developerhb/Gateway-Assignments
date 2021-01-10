using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCScaffoldDemo.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Enrollment { get; set; }

        public int Age { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public StudentDBContext() { }

        public DbSet<Student> Students { get; set; }
    }
}
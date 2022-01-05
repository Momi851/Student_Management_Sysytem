using Student_Management_Sysytem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.DataContext
{
    public class AppDBContext : DbContext
    {
       
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Courses> Coursess { get; set; }

        public DbSet<Assign_Course> Assign_Courses { get; set; }
        public DbSet<Class> _Class { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Enroll_Now> Enrollment { get; set; } 
        public DbSet<AdminLogin> AdminLogins{ get; set; }

        public DbSet<FeeBill> FeeBills { get; set; }



    }
}
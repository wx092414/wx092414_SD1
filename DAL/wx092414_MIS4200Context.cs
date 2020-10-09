using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using wx092414_SD1.Models;

namespace wx092414_SD1.DAL
{
    public class MIS4200Context : DbContext 
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Course> course  { get; set; }
        public DbSet<Student> student  { get; set; }
        public DbSet<Professor> professor { get; set; }
        public DbSet<Enrollment> enrollment  { get; set; }
        public DbSet<userData> userData { get; set; }
    }
    
}
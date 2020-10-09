using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wx092414_SD1.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string fristName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public ICollection<Course> course { get; set; }
    }
}
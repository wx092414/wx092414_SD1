using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wx092414_SD1.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseTitle { get; set; }
        public string courseDescription { get; set; }
        public string professor { get; set; }
        public int studentID { get; set; }
        public virtual Student student { get; set; }
        public ICollection<Enrollment> enrollment { get; set; }
       
    }
}
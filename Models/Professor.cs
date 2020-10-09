using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wx092414_SD1.Models
{
    public class Professor
    {
        public int professorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public ICollection<Enrollment> enrollment { get; set; }
    }
}
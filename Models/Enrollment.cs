using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wx092414_SD1.Models
{
    public class Enrollment
    {
        [Key]
        public int enrollmentID { get; set; }
      
        public DateTime enrollmentDate { get; set; }
        public int courseID { get; set; }
        public int ProfessorID { get; set; }
        public virtual Course course { get; set; }
        public virtual Professor professor { get; set; }


        


    }
}
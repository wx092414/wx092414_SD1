using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wx092414_SD1.Models
{
    public class userData
    {
        public Guid ID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string fullName 
         {
                get
                {
                    return lastName + ", " + firstName;
                }
      
        }
        public string officeLocation { get; set; }
        public DateTime startDate { get; set; }
    }
}
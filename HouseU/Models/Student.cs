using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseU.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumber { get; set; }
        public bool OnCampus { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
    }
}
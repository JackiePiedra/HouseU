using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseU.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        //[Required]
        //[Display(Name ="Course Name", Prompt ="Enter a course name", Description="Course Name")]
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int CreditHours { get; set; }
        public string Location { get; set; }
        public int Section { get; set; }
    }
}
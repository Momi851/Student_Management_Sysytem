using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class Assign_Course
    {
        [Key]
        public  int ID { get; set; }
        public int TeacherId { get; set; }
        // Navigation Property
        [ForeignKey("TeacherId")]
        public  Teacher Teachers { get; set; }

        public int CourseId { get; set; }
        // Navigation Property
        [ForeignKey("CourseId")]
        public Courses _Courses { get; set; }
    }
}

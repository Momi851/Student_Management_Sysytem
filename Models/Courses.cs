using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class Courses
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        public string Subject { get; set; }
       

       

    }
}
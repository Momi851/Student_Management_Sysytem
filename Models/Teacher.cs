using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class Teacher
    {
        [Key]
        public int Teacher_Id { get; set; }

        [Required]
        public string Teacher_Name { get; set; }
        public string Qualification { get; set; }
        public string Gender { get; set; }
        public string Email_Address { get; set; }
        public string Address { get; set; }
        public string Contact_Number { get; set; }
        
    }
}
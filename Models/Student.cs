using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name{ get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        
        public string Emergency_Contact_No { get; set; }
        public string Blood_Group { get; set; }

    }
}
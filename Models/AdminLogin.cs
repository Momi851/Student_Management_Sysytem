using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Student_Management_Sysytem.Models
{
    public class AdminLogin
    {
        [Key]
        public int Admin_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
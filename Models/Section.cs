using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        [Required]
        public string Section_Name { get; set; }

    }
}
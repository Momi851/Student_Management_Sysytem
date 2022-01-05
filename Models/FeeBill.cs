using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class FeeBill
    {
        [Key]
        public int Fee_ID { get; set; }
        public string Student_Name { get; set; }
        public int SectionId { get; set; }
        // Navigation Property
        [ForeignKey("SectionId")]
        public Section Sections { get; set; }

        public int Class_ID { get; set; }
        // Navigation Property
        [ForeignKey("Class_ID")]
        public Class Classes { get; set; }
        public string Admission_Fee { get; set; }
        public string Monthly_Fee { get; set; }






    }
        
}

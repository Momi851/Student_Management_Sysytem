using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Management_Sysytem.Models
{
    public class Class
    {
        [Key]
        public int Class_ID { get; set; }
        public string _Class { get; set; }
        public string Class_Teacher { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Project2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [DefaultValue("")]
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
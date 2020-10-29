using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace practice1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [DisplayName("Name")]
        public string StudentName { get; set; }

        public string Gender { get; set; }

        [DisplayName("NewlyEnrolled ")]
        public bool isNewlyEnrolled { get; set; }

        public string Grade { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
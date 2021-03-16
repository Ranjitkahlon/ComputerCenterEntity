using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerCenterEntity.DataLayer
{
    public class Course
    {
        public int id { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Content ")]
        public string Material { get; set; }

        [Display(Name = "Fee")]
        public int fee { get; set; }


    }
}

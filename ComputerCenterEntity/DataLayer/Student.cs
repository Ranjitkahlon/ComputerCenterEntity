using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerCenterEntity.DataLayer
{
    public class Student
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [Display(Name = "Contact")]
        public string Contact { get; set; }


        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Course")]
        public string Course { get; set; }

        [Display(Name = "Fee")]
        public int fee { get; set; }


    }
}

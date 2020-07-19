using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class StudentDetails
    {
        public int stuId { get; set; }
        public string stuName { get; set; }
        public string stuCollege { get; set; }
        public string stuBranch { get; set; }
        public int stuAge { get; set; }
    }
}
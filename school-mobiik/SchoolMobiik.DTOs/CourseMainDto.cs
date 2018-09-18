using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.Entities;

namespace SchoolMobiik.DTOs
{
    public class CourseMainDto
    {               
        public string SchoolId { get; set; }      
        public string TeacherName { get; set; }
        public int Year { get; set; }
        public string SignatureName { get; set; }
    }
}

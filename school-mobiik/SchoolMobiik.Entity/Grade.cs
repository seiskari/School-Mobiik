using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Grade
    {
        public string CourseId { get; set; }
        public int StudentId { get; set; }
        public string Grade1 { get; set; }
        public bool? IsActive { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Grade
    {
        public string CourseId { get; set; }
        public int StudentId { get; set; }
        public string Grade1 { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

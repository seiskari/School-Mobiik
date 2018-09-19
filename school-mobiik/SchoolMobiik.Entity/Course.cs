using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Course
    {
        public Course()
        {
            Grade = new HashSet<Grade>();
            Schedule = new HashSet<Schedule>();
        }

        public string CourseId { get; set; }
        public int SignaturesId { get; set; }
        public string SchoolId { get; set; }
        public int TeacherId { get; set; }
        public int? MinToPass { get; set; }
        public int Year { get; set; }
        public int? Credits { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public School School { get; set; }
        public Signatures Signatures { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Grade> Grade { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
    }
}

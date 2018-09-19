using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Schedule
    {
        public string CourseId { get; set; }
        public int WdId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Course Course { get; set; }
        public WeekDay Wd { get; set; }
    }
}

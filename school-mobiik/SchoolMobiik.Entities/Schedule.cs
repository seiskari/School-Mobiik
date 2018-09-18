using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entities
{
    public partial class Schedule
    {
        public Schedule()
        {
            Course = new HashSet<Course>();
        }

        public int ScheduleId { get; set; }
        public int WdId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public WeekDay Wd { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}

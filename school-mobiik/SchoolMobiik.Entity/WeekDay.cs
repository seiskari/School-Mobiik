using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int WdId { get; set; }
        public string Day { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}

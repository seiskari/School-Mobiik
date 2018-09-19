using System;
using System.Collections.Generic;

namespace ClassLibrary1
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

using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Course = new HashSet<Course>();
            Work = new HashSet<Work>();
        }

        public int PersonId { get; set; }
        public int TeacherId { get; set; }
        public string Rfc { get; set; }
        public bool? IsActive { get; set; }

        public Person Person { get; set; }
        public ICollection<Course> Course { get; set; }
        public ICollection<Work> Work { get; set; }
    }
}

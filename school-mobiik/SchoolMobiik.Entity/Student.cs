using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Student
    {
        public Student()
        {
            Grade = new HashSet<Grade>();
            Inscription = new HashSet<Inscription>();
        }

        public int PersonId { get; set; }
        public int StudentId { get; set; }
        public string Account { get; set; }
        public bool? IsActive { get; set; }

        public Person Person { get; set; }
        public ICollection<Grade> Grade { get; set; }
        public ICollection<Inscription> Inscription { get; set; }
    }
}

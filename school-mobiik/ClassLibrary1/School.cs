using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class School
    {
        public School()
        {
            Course = new HashSet<Course>();
            Inscription = new HashSet<Inscription>();
            Work = new HashSet<Work>();
        }

        public string SchoolId { get; set; }
        public int AddressId { get; set; }
        public string SchoolName { get; set; }
        public int SchoolType { get; set; }
        public int? MinToPass { get; set; }
        public bool? IsActive { get; set; }

        public Address Address { get; set; }
        public SchoolType SchoolTypeNavigation { get; set; }
        public ICollection<Course> Course { get; set; }
        public ICollection<Inscription> Inscription { get; set; }
        public ICollection<Work> Work { get; set; }
    }
}

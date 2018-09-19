using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Person
    {
        public Person()
        {
            Student = new HashSet<Student>();
            Teacher = new HashSet<Teacher>();
        }

        public int PersonId { get; set; }
        public DateTime Birthday { get; set; }
        public int AddressId { get; set; }
        public string Curp { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int SchoolUser { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }

        public Address Address { get; set; }
        public Roles Rol { get; set; }
        public ICollection<Student> Student { get; set; }
        public ICollection<Teacher> Teacher { get; set; }
    }
}

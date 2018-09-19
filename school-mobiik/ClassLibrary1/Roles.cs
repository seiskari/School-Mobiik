using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Roles
    {
        public Roles()
        {
            Person = new HashSet<Person>();
            SchoolUser = new HashSet<SchoolUser>();
        }

        public int RolId { get; set; }
        public string RolName { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Person> Person { get; set; }
        public ICollection<SchoolUser> SchoolUser { get; set; }
    }
}

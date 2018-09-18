using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entities
{
    public partial class Address
    {
        public Address()
        {
            Person = new HashSet<Person>();
            School = new HashSet<School>();
        }

        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public int Neighborhood { get; set; }
        public string ExtNum { get; set; }
        public string IntNum { get; set; }

        public ZipCode NeighborhoodNavigation { get; set; }
        public ICollection<Person> Person { get; set; }
        public ICollection<School> School { get; set; }
    }
}

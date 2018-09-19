using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Address
    {
        public Address()
        {
            Person = new HashSet<Person>();
            School = new HashSet<School>();
        }

        public int AddressId { get; set; }
        public string Street { get; set; }
        public int Neighborhood { get; set; }
        public string ExtNum { get; set; }
        public string IntNum { get; set; }

        public ZipCode NeighborhoodNavigation { get; set; }
        public ICollection<Person> Person { get; set; }
        public ICollection<School> School { get; set; }
    }
}

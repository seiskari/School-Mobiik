using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entities
{
    public partial class ZipCode
    {
        public ZipCode()
        {
            Address = new HashSet<Address>();
        }

        public int Neighborhood { get; set; }
        public int CityId { get; set; }
        public string Zcname { get; set; }

        public City City { get; set; }
        public ICollection<Address> Address { get; set; }
    }
}

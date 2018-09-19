using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class City
    {
        public City()
        {
            ZipCode = new HashSet<ZipCode>();
        }

        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }

        public State State { get; set; }
        public ICollection<ZipCode> ZipCode { get; set; }
    }
}

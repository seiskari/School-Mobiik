using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class SchoolType
    {
        public SchoolType()
        {
            School = new HashSet<School>();
        }

        public int SchoolTypeId { get; set; }
        public string Type { get; set; }

        public ICollection<School> School { get; set; }
    }
}

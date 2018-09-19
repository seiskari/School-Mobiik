using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Signatures
    {
        public Signatures()
        {
            Course = new HashSet<Course>();
        }

        public int SignaturesId { get; set; }
        public string SignaturesName { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Course> Course { get; set; }
    }
}

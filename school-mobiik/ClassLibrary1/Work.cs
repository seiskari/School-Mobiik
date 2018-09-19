using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Work
    {
        public int TeacherId { get; set; }
        public string SchoolId { get; set; }

        public School School { get; set; }
        public Teacher Teacher { get; set; }
    }
}

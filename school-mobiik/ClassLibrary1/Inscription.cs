using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Inscription
    {
        public int StudentId { get; set; }
        public string SchoolId { get; set; }
        public DateTime InscriptionDate { get; set; }

        public School School { get; set; }
        public Student Student { get; set; }
    }
}

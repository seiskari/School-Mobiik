using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
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

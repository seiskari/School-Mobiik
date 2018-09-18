using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.Entities;

namespace SchoolMobiik.DTOs
{
    class CurseMainDto
    {               
        public int SchoolId { get; set; }      
        public Teacher Teacher { get; set; }
        public Schedule Schedule { get; set; }
        public Signatures Signatures { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolMobiik.DTOs
{
    public class SchoolUserDTO
    {
        public int SchoolUserId { get; set; }
        public int RolId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entities
{
    public partial class SchoolUser
    {
        public int PersonId { get; set; }
        public int RolId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }

        public Roles Rol { get; set; }
    }
}

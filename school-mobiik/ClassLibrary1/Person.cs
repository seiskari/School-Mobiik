using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public int AddressId { get; set; }
        public byte[] Curp { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }

        public Address Address { get; set; }
        public Roles Rol { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}

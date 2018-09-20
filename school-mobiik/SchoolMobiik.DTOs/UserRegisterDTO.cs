using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolMobiik.DTOs
{
    public class UserRegisterDTO
    {
        public DateTime Birthday { get; set; }
        public string CURP { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Street { get; set; }
        public string ExtNum { get; set; }
        public string IntNum { get; set; }
        public int Neighborhood { get; set; }
        public string UserName {get;set;}
        public string Password { get; set; }
    }
}

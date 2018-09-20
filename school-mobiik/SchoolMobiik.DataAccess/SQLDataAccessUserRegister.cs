using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.Entity;
using System.Linq;

namespace SchoolMobiik.DataAccess
{
    public class SQLDataAccessUserRegister : IDisposable
    {

        public SQLDataAccessUserRegister()
        {
        }

        public Person GetPerson()
        {
            using (var context = new SemillerosDBContext())
            {

            }
        }

        public SchoolUser GetSchoolUser()
        {
            using (var context = new SemillerosDBContext())
            {

            }
        }

        public Address GetAddress()
        {
            using (var context = new SemillerosDBContext())
            {

            }
        }

        public void Dispose()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.Entities;
using System.Linq;

namespace SchoolMobiik.DataAccess
{
    public class SQLDataAccessSchoolUser : IDisposable
    {
        public SQLDataAccessSchoolUser()        
        {            
        }

        public SchoolUser GetSchoolUser(string userName)
        {
            using (var context = new SchoolDatabaseContext())
            {
                var SchoolUserRegistered = context.SchoolUser.Where(s => s.UserName == userName).FirstOrDefault() ;
                return SchoolUserRegistered;
            }
        }

        public void Dispose()
        {
        }
    }
}

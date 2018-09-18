using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.Entities;
using System.Linq;

namespace SchoolMobiik.DataAccess
{
    public class SQLDataAccessCourse:IDisposable
    {
        public SQLDataAccessCourse()
        {

        }
        public IEnumerable<Course> GetCoursesSignature(string signatureName)
        {
            List<Course> CourseList = new List<Course>();
            using (var context = new SchoolDatabaseContext())
            {
                var list = context.Course.Where(s => s.Signatures.SignaturesName == signatureName).ToList();
               
                CourseList = list;
            }
            return CourseList;
        }

        public IEnumerable<Course> GetCourses(string schoolId)
        {
            List<Course> CourseList = new List<Course>();
            using (var context = new SchoolDatabaseContext())
            {
                var list = context.Course.Where(s => s.SchoolId == schoolId).ToList();

                CourseList = list;
            }
            return CourseList;
        }

        public void Dispose()
        {
        }

    }
}

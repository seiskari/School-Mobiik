using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.DTOs;
using SchoolMobiik.Entities;
using SchoolMobiik.DataAccess;
using System.Linq;


namespace SchoolMobiik.BussinessLayer
{
    public class ProcessCourse
    {
        public IEnumerable<CourseMainDto> GetCoursesBySchool(string schoolId)
        {
            List<CourseMainDto> listCourses = new List<CourseMainDto>();
            using (var sqlDataAccessCourse = new SQLDataAccessCourse()) {
                var list = sqlDataAccessCourse.GetCourses(schoolId).Where(
                    item => item.IsActive == true);

                list.ToList().ForEach(item => {
                    listCourses.Add(MapEntityCourseToDto(item));
                });
            }
            return listCourses;
        }

        public IEnumerable<CourseMainDto> GetCourseBySignatureName(string signatureName)
        {
            List<CourseMainDto> listCourses = new List<CourseMainDto>();
            using (var sqlDataAccessCourse = new SQLDataAccessCourse())
            {
                var list = sqlDataAccessCourse.GetCoursesSignature(signatureName).Where(
                    item => item.IsActive == true);

                list.ToList().ForEach(item => {
                    listCourses.Add(MapEntityCourseToDto(item));
                });
            }
            return listCourses;
        }


        /// <summary>
        /// Mapeos
        /// </summary>
        public CourseMainDto MapEntityCourseToDto(Course course)
        {
            return new CourseMainDto
            {
                CourseId = course.CourseId,
                SchoolId = course.SchoolId,
                TeacherName = course.Teacher.Person.PersonName,
                Year = course.Year,
                SignatureName = course.Signatures.SignaturesName,
                IsActive = course.IsActive
            };

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.DTOs;
using SchoolMobiik.Entities;

namespace SchoolMobiik.BussinessLayer
{
    public class ProcessCourse
    {


        /// <summary>
        /// Mapeos
        /// </summary>
        public CourseMainDto MapEntityCourseToDto(Course course)
        {
            return new CourseMainDto
            {
                SchoolId = course.SchoolId,
                TeacherName = course.Teacher.Person.PersonName,
                Year = course.Year,
                SignatureName = course.Signatures.SignaturesName
            };


        }
    }
}

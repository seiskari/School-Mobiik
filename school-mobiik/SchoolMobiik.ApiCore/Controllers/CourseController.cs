using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMobiik.BussinessLayer;
using SchoolMobiik.DTOs;

namespace SchoolMobiik.ApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ProcessCourse processCourse;
        public CourseController()
        {
            processCourse = new ProcessCourse();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<CourseMainDto> Get(string schoolId)
        {
            var courseList = processCourse.GetCoursesBySchool(schoolId);
            return courseList;
            //return new string[] { "value1", "value2" };
        }

    }
}
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
    [Route("schools")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ProcessCourse processCourse;
        public CourseController()
        {
            processCourse = new ProcessCourse();
        }

        // GET api/values
        [HttpGet("{schoolId}/courses")]
        public IEnumerable<CourseMainDto> Get(string schoolId)
        {
            //schoolId = "Escuela1";
            var courseList = processCourse.GetCoursesBySchool(schoolId);         
            return courseList;
           
        }
     
        [HttpGet("{schoolId}/courses/{signatureName}")]
        public IEnumerable<CourseMainDto> Get(string schoolId,string signatureName)
        {                        
            //schoolId = "Escuela1";
            //signatureName = "Español";
            var courseList = processCourse.GetCourseBySignatureName(schoolId,signatureName);
            return courseList;
        }






    }
}
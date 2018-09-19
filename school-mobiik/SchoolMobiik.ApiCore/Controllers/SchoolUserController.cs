using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMobiik.DTOs;
using SchoolMobiik.BussinessLayer;
using System.Web.Http.Description;
using System.Net.Http;
using System.Net;

namespace SchoolMobiik.ApiCore.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    
    public class SchoolUserController : ControllerBase
    {
        ProccessUserSchool proccessUserSchool;

        public SchoolUserController()
        {
            proccessUserSchool = new ProccessUserSchool();
        }

        [HttpGet, Route("api/SchoolUser/{userName}/{password}")]
        //[HttpGet]
        [ResponseType(typeof(SchoolUserDTO))]
        public SchoolUserDTO GetSchoolUser(string userName, string password)
        {
            //userName = "Juanga";
            //password = "reseña";
            HttpRequestMessage Request = new HttpRequestMessage();
            SchoolUserDTO schoolUserDTO = proccessUserSchool.GetUserSchool(userName, password);
            if (schoolUserDTO != null)
            {             
                return schoolUserDTO;
            }
            else
            {                
                return schoolUserDTO;
            }
        }
    }
}
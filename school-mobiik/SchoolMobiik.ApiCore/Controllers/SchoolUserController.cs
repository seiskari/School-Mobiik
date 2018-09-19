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
using SchoolMobiik.Entities;

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

        [HttpPost, Route("api/SchoolUser/")]
        //[HttpGet]
        [ResponseType(typeof(SchoolUserDTO))]
        public SchoolUserDTO PostSchoolUser([FromBody]SchoolUserDTO schoolUser)
        {
            //userName = "Juanga";
            //password = "reseña";
            HttpRequestMessage Request = new HttpRequestMessage();
            SchoolUserDTO schoolUserDTO = proccessUserSchool.GetUserSchool(schoolUser.UserName, schoolUser.Password);
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
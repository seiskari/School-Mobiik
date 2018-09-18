using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SchoolMobiik.DTOs;
using SchoolMobiik.BussinessLayer;
using System.Net;
using System.Web.Http.Description;
using System.Web.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using System.Net.Http;

namespace SchoolMobiik.Api.Controllers
{
    [Route("api/SchoolUser")]
    public class SchoolUserController : ApiController
    {
        ProccessUserSchool proccessUserSchool;

        public SchoolUserController()
        {
            proccessUserSchool = new ProccessUserSchool();
        }

        [HttpGet, Route("SchoolUser/{userName}/{password}")]
        [ResponseType(typeof(SchoolUserDTO))]
        public HttpResponseMessage GetSchoolUser (string userName, string password)
        {
            SchoolUserDTO schoolUserDTO = proccessUserSchool.GetUserSchool(userName, password);
            if (schoolUserDTO != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

    }
}
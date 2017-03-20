using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApi.Controllers
{
    public class BiginnerController : ApiController
    {
        [HttpGet]
        public string Get()
        { 
        string message = "Hello from kanon ";
        return message;
        }


        [HttpPost]
        public string Post(int id)
        {
            return $"Hello with id {id}";
        }










    }     
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class HomeApiController: ApiController
    {

        public string Get(string name)
        {
            string value = "Hi ";
            value = value + name;
            return value;
        }

    }
}
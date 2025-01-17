﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {   // GET: /<controller>/
        [HttpGet]
        //[Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                       "<input type='text' name='name' />" +
                       "<input type='submit' value='Greet Me!' />" +
                       "</form>";

            return Content(html, "text/html");
        }
        // GET /hello/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        // [Route("/helloworld/")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

    }
}

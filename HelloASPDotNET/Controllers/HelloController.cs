using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/hello/")]
    public class HelloController : Controller
    {   // GET: /<controller>/
        [HttpGet]
        //[Route("/helloworld/")]
        public IActionResult Index()
        {
            return View();
        }
        // GET /hello/welcome

        [HttpPost]
        // [Route("/helloworld/")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

    }
}

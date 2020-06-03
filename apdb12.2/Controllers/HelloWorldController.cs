using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace apdb12._2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(int id,string name,int numTimes = 2)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
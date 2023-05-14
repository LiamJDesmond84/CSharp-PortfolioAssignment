using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_PortfolioAssignment.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;

            ViewBag.Time = CurrentTime;
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }




        [HttpPost("send")]
        public void Send(string name, string email)
        {
            Console.WriteLine($"My name is {name} and my email is {email}");
/*            return RedirectToAction("Result", name, email);*/
        }


        [HttpGet("survey")]
        public IActionResult Survey()
        {
            return View();
        }


        [HttpPost("submit")]
        public IActionResult Submit(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View();

        }


    }
}

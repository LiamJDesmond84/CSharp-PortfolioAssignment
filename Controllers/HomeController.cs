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




        [HttpPost("submit")]
        public void Submit(string name, string email)
        {
            Console.WriteLine($"My name is {name} and my email is {email}");
/*            return RedirectToAction("Result", name, email);*/
        }


    }
}

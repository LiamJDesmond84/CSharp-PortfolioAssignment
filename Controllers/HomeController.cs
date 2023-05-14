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

    }
}

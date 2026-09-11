using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThirdGroup_1.Models;

namespace ThirdGroup_1.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            //  return Content("Hello Abdo");
           //  ViewBag.Name = "Samar";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

 
    }
}

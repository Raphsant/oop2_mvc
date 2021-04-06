using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaphMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(string Name)
        {
            ViewData["Message"] = $"Hello {Name} from MVC";
            ViewBag.Name = Name;
            return View();
        }
    }
}

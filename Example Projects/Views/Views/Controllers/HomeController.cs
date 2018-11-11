using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView", new string[] { "Apple", "Orange", "Pear" });
        }

        public ViewResult List() => View();
    }
}

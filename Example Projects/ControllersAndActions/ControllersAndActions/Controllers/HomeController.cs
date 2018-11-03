using ControllersAndActions.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        public IActionResult ReceiveForm(string name, string city)
        {
            return View("Result", $"{name} lives in {city}");
        }
    }
}

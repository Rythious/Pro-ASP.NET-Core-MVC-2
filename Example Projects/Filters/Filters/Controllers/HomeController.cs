using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Message", "This is the Index action on the Home controller");
        }

        public ViewResult SecondAction()
        {
            return View("Message", "This is the SecondAction action on the Home controller");
        }
    }
}

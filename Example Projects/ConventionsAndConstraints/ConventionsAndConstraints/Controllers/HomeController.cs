using ConventionsAndConstraints.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConventionsAndConstraints.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Index) });

        [ActionName("Details")]
        public IActionResult List() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(List) });
    }
}

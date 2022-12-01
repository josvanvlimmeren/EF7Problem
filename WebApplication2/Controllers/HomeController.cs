using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestEF7.Models;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TempDataContext Context;

        public HomeController(ILogger<HomeController> logger, TempDataContext context)
        {
            _logger = logger;
            Context = context;
        }

        public IActionResult Index()
        {
            var firstUser = Context.AspNetUsers.FirstOrDefault();
            var userRoles = firstUser.Roles.ToList(); //This gives an error!
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
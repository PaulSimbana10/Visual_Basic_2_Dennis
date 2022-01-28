using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebCole.Models;

namespace WebCole.Controllers
{
    public class HomeControllers : Controller
    {
        private readonly ILogger<HomeControllers> _logger;

        public HomeControllers(ILogger<HomeControllers> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

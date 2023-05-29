using Microsoft.AspNetCore.Mvc;
using PROYECTO_ITLA.Models;
using System.Diagnostics;

namespace PROYECTO_ITLA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
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

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Pilares()
        {
            return View();
        }

        public IActionResult Aprendizaje()
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
using FlagAcademy.DataAccess;
using FlagAcademy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlagAcademy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FlagAcademyContext _context;
        public HomeController(ILogger<HomeController> logger, FlagAcademyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           // var flag = _context.Flags.First();
            return View();
        }

        [Route("/play")]
        public IActionResult Play()
        {
            var country = _context.Countries.First();
            return View(country);
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

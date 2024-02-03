using FlagAcademy.DataAccess;
using FlagAcademy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Metrics;

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
            Random rnd = new Random();
            int randomFlag = rnd.Next(1, 6);

            var country = _context.Countries.Where(c=>c.Id == randomFlag).First();
            var countries = _context.Countries.ToList();

            ViewData["countries"] = GenerateWrongAnswers(country);

            return View(country);
        }


        public List<Country> GenerateWrongAnswers(Country correctAnswer)
        {
            List<Country> wrongAnswers = new List<Country>();
            Random rnd = new Random();
            
            while (wrongAnswers.Count < 4)
            {
                int num = rnd.Next(1, 6);
                var country = _context.Countries.Where(c => c.Id == num).First();
                //makes sure your not adding duplicates of the correct guess of two of the same wrong answers.
                if(country != correctAnswer && !wrongAnswers.Contains(country))
                {
                    wrongAnswers.Add(country);
                }
            }
            var shuffledCountries = ShuffleGuesses(wrongAnswers, correctAnswer);
            return shuffledCountries;
        }

        public List<Country> ShuffleGuesses(List<Country>countries, Country correctAnswer)
        {
            List<Country> shuffledCountries = new List<Country>();
            Random rnd = new Random();
            int position = rnd.Next(0, 4);

            for (int i = 0; i < countries.Count; i++)
            {
                if(i == position)
                {
                    shuffledCountries.Add(correctAnswer);
                }
                else
                {
                    shuffledCountries.Add(countries[i]);
                }
            }

            return shuffledCountries;
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

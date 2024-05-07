using Microsoft.AspNetCore.Mvc;

namespace FlagAcademy.Controllers
{
    public class SettingsController : Controller
    {
        [HttpGet]
        [Route("/Settings")]
        public IActionResult Settings()
        {
            return View();
        }

        [HttpPost]
        [Route("/updateSettings")]
        public IActionResult UpdateSettings(int gameLength)
        {
            UpdateGameLength(gameLength);
            return Redirect("/");
        }

        public void UpdateGameLength(int gameLength)
        {
           Response.Cookies.Append("GameLength", gameLength.ToString());
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            ViewBag.v1 = "Film Listesi";
            ViewBag.v2 = "Ana Sayfa";
            ViewBag.v3 = "Tüm Filmler";
            return View();
        }
    }
}

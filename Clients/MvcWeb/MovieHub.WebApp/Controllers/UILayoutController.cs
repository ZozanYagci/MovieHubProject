using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}

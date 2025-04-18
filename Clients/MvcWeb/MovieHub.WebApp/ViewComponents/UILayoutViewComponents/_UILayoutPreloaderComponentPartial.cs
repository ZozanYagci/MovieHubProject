using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutPreloaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

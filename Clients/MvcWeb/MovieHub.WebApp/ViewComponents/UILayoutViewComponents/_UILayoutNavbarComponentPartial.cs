using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

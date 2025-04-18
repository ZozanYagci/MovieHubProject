using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutHeroComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

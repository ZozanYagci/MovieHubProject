using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.ViewComponents.MovieDetailViewComponents
{
    public class _MovieImageAndWatchTrailerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

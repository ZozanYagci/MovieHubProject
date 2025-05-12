using Microsoft.AspNetCore.Mvc;

namespace MovieHub.WebApp.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailRelatedMoviesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

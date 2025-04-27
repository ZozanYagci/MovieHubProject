using Microsoft.AspNetCore.Mvc;
using MovieHub.Application.Features.Dtos.MovieDtos;
using Newtonsoft.Json;

namespace MovieHub.WebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public MovieController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> MovieList()
        {
            ViewBag.v1 = "Film Listesi";
            ViewBag.v2 = "Ana Sayfa";
            ViewBag.v3 = "Tüm Filmler";

            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7246/api/Movies");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}

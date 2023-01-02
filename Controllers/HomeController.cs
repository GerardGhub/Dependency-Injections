using Microsoft.AspNetCore.Mvc;

namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        private readonly CitiesService citiesService;

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

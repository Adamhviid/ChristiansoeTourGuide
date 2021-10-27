using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChristiansoeTourGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Attractions()
        {
            return View();
        }
        public IActionResult Map()
        {
            return View();
        }
        public IActionResult OrderTour()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
        
    

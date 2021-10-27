using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChristiansoeTourGuide.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        //
        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        //
        // public IActionResult Index()
        // {
        //     return View();
        // }
        
        
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult DisplayImage()
        {
            var webRoot = _env.WebRootPath;
            var file = System.IO.Path.Combine(webRoot, "\\images\\ducktales.png");
            return File(file, "image/png");
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
        
    

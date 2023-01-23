using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSecurity_Day02_Secret.Models;

namespace WebSecurity_Day02_Secret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var adminUserName = _configuration["adminLogin:Username"];
            var adminPassword = _configuration["AdminLogin:Password"];
            var connectionString = _configuration["ConnectionStrings:DefaultConnection"];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
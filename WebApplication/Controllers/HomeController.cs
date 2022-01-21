using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using System.Diagnostics;
using WebApplication.Services;
using MimeKit;
using MailKit.Net.Smtp;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public RestService _rs { get; set; }
        private readonly EmployeeContext _context;
        private  IConfiguration Configuration { get; set; }
        public HomeController(ILogger<HomeController> logger, EmployeeContext context, IConfiguration _configuration)
        {
            _logger = logger;
            _context = context;
            _rs = new RestService(_context, _configuration);
            Configuration = _configuration;
        }

        public IActionResult Index()
        {
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
   
        public IActionResult WeatherData(string id)
        {
            var apikey = Configuration["MyAPIKEY"];
            string weatherapiData = "https://api.openweathermap.org/data/2.5/forecast?q=+" + id + "&units=metric&appid=" +apikey;

            WeatherData results = _rs.GetWeatherData(weatherapiData).Result;
           
            return View(results);
        }
    }
}

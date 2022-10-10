using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            //List<Data> Member = new List<Data>();
            //Member.Add(new Data { Id = 1, Name = "Jack", City = "Chiang Mai" });
            //Member.Add(new Data { Id = 2, Name = "Jang", City = "Chiang Rai" });
            //Member.Add(new Data { Id = 3, Name = "Jun", City = "Lamphun" });
            //Member.Add(new Data { Id = 4, Name = "Tom", City = "Nan" });
            //Member.Add(new Data { Id = 5, Name = "Sara", City = "Phrae" });
            //return View(Member.ToList());
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
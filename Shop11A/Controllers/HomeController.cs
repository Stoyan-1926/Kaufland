using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shop11A.Models;

namespace Shop11A.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public List<Product> products = new List<Product>
        {
            new Product{ Id = 1, Name = "Tablet 11a", Description = "Super mega giga tablet 11a", Price = 1000.11M, ImageUrl = "/images/t1.jpg" },
            new Product{ Id = 2, Name = "Tablet 11b", Description = "Super mega giga tablet 11b", Price = 1234.11M, ImageUrl = "/images/t2.jpg" },
            new Product{ Id = 3, Name = "Tablet 11c", Description = "Super mega giga tablet 11c", Price = 1500.11M, ImageUrl = "/images/t3.jpg" },

            new Product{ Id = 4, Name = "MehanoPhone 11d", Description = "Super mega giga MehanoPhone 11d", Price = 1500.11M, ImageUrl = "/images/p1.jpg" },
            new Product{ Id = 5, Name = "MehanoPhone 11e", Description = "Super mega giga MehanoPhone 11e", Price = 1600.11M, ImageUrl = "/images/p2.jpg" },
            new Product{ Id = 6, Name = "MehanoPhone 11f", Description = "Super mega giga MehanoPhone 11f", Price = 1700.11M, ImageUrl = "/images/p3.jpg" }
        };

        public IActionResult Index()
        {
            return View(products);
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

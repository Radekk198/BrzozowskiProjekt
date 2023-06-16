using BrzozowskiRadoslawProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BrzozowskiRadoslawProjekt.Controllers
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
            var products = new List<ProductModel>
        {
            new ProductModel
            {
                ImageUrl = "https://www.gry-online.pl/Galeria/Html/Wiadomosci/362250734.jpg",
                Title = "RAM Memory",
                Description = "You can choose from the popular DDR4 or the latest DDR5",
                Url = "#"
            },
            new ProductModel
            {
                ImageUrl = "https://gagadget.com/media/cache/bb/7c/bb7c8023f79715812007e07fa2c295bc.jpg",
                Title = "Graphics Card",
                Description = "Choose a graphics card based on your needs",
                Url = "#"
            },
            new ProductModel
            {
                ImageUrl = "https://www.mobimaniak.pl/wp-content/uploads/mobimaniak/2021/01/Philips_439P9H_SuperWide.jpg",
                Title = "Monitor",
                Description = "You can choose from different resolutions, refresh rates and other parameters",
                Url = "#"
            }
        };

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
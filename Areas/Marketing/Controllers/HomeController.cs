using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Semana02DPA_MVC.Areas.Marketing.Models;

namespace Semana02DPA_MVC.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsViewModel()
        {
            var products = GetProducts();
            return View("ProductsViewModel", products);
        }

        public IActionResult ProductsViewData() {
            var products = GetProducts();
            ViewData["ProductList"] = products;
            ViewData["TitleViewData"] = "Products with View Data";
            return View("ProductsViewData");
        }

        public IActionResult ProductsViewBag()
        {
            var products = GetProducts();
            ViewBag.ProductList = products;
            ViewBag.TitleViewBag = "Products with View Bag";
            return View("ProductsViewBag");
        }

        //Get JSON in Product
        private IEnumerable<Product> GetProducts() {

            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Areas\\Marketing\\Data\\products.json");
            var json = System.IO.File.ReadAllText(folder);

            var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
            return products;
        }
        
    }
}

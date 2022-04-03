using Microsoft.AspNetCore.Mvc;

namespace Semana02DPA_MVC.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

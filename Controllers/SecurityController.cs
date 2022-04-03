using Microsoft.AspNetCore.Mvc;

namespace Semana02DPA_MVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

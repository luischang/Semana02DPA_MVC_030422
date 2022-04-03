using Microsoft.AspNetCore.Mvc;

namespace Semana02DPA_MVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validate(string email, string password)
        {
            if (email == "admin@peru.com" && password == "admin")
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
            }
            else
            {
                return View("Login");
            }
        }
    }
}

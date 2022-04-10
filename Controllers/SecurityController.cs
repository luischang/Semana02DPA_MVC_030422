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
        //public IActionResult Validate(string correo, string clave)
        public IActionResult Validate(IFormCollection form)
        {
            var email = form["correo"];
            var password = form["clave"];

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

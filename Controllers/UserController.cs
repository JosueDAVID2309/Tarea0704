using Microsoft.AspNetCore.Mvc;

namespace tarea0704.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar() {
            return View();
        }
    }
}

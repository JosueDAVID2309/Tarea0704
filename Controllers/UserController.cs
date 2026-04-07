using tarea0704.Controllers.repository;
using Microsoft.AspNetCore.Mvc;

namespace tarea0704.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string contraseña)
        {
            UserRepository userRepository = new UserRepository();
            string[] parametros = ["'"+correo+"'", "'"+contraseña+"'"];
            Boolean existe = userRepository.verificarUsuario(parametros);

            ViewBag.Mensaje = existe ? "Bienvenido " + correo : "Credenciales Incorrectas";

            return View();
        }
    }
}

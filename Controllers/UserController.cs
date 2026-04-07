using tarea0704.Controllers.repository;
using tarea0704.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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

            if(existe){
                User user = userRepository.ObtenerUsuario(correo);
                ViewBag.Mensaje = "Bienvenido " + user.Nombres + " "+ user.Apellidos;
            }
            else
            {
                ViewBag.Mensaje = "Credenciales Incorrectas";
            }

            return View();
        }
    }
}

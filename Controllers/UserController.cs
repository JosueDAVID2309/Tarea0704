using tarea0704.Controllers.repository;
using tarea0704.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace tarea0704.Controllers
{
    public class UserController : Controller
    {
        UserRepository userRepository = new UserRepository();

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
            
            string[] parametros = ["'"+correo+"'", "'"+contraseña+"'"];
            Boolean existe = userRepository.verificarUsuario(parametros);

            if(existe){
                User user = userRepository.ObtenerUsuario(correo);
                ViewBag.Mensaje = "Bienvenido " + user.Nombres + " "+ user.Apellidos;
                ViewBag.FNacimiento = user.f_nacimiento;
            }
            else
            {
                ViewBag.Mensaje = "Credenciales Incorrectas";
            }

            return View();
        }

        [HttpPost]
        public IActionResult Registrarse(User user)
        {
            Console.Write(user);
            userRepository.registarUsuario(user);

            return RedirectToAction("Index", "User");
        }
    }
}

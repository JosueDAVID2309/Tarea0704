using tarea0704.Controllers.db;
using tarea0704.Models;
using System.Data.SqlClient;
using System.Data;

namespace tarea0704.Controllers.repository
{
    public class UserRepository
    {
        
        public void registarUsuario(User user)
        {
            DB db = new DB();

            string[] parametros = [
                user.Nombres,
                user.Apellidos,
                user.usuario,
                user.genero,
                user.f_nacimiento,
                user.dni,
                user.correo,
                user.contraseña
                ];

            db.EjecutarSQL("sp_registrar", parametros);
        }
    }
}

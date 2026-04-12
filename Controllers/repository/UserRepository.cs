using tarea0704.Controllers.db;
using tarea0704.Models;
using System.Data;

namespace tarea0704.Controllers.repository
{
    public class UserRepository
    {

        public void registarUsuario(User user)
        {
            DB db = new DB();

            string[] parametros = [
                "'"+ user.Nombres +"'",
                "'"+ user.Apellidos +"'",
                "'"+ user.usuario +"'",
                "'"+ user.genero +"'",
                "'"+ user.f_nacimiento +"'",
                "'"+ user.dni +"'",
                "'"+ user.correo+"'",
                "'"+ user.contraseña +"'"
                ];

            
            db.EjecutarSQL("sp_registrar", parametros);
        }

        public Boolean verificarUsuario(string[] parametros)
        {
            DB db = new DB();
            DataTable dt = db.EjecutarSQL("verificarUsuario ", parametros);

            return dt.Rows.Count > 0;
        }

        public User ObtenerUsuario(string correo)
        {
            DB db = new DB();
            string[] parametros = ["'" + correo + "'"];
            DataTable dt = db.EjecutarSQL("obtenerUsuarioCorreo ", parametros);
            User user = new User(dt.Rows[0]);

            return user;
        }
    }
}

using tarea0704.Controllers.db;
using System.Data.SqlClient;
using System.Data;

namespace tarea0704.Controllers.repository
{
    public class UserRepository
    {
        DB db = new DB(); 
        public void registarUsuario()
        {
            String sql = "INSERT INTO Usuarios (nombres, apellidos, usuarios, genero, f_nacimiento, dni, correo, contraseña) VALUES ";
            DataTable dt = new DataTable(db.EjecutarSQL());
        }
    }
}

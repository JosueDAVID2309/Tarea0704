using System.Data;

namespace tarea0704.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string usuario { get; set; }
        public string genero { get; set; }
        public string f_nacimiento { get; set; }
        public string dni { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }

        public User(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.Nombres = row["nombres"].ToString();
            this.Apellidos = row["apellidos"].ToString().Trim();
            this.usuario = row["usuarios"].ToString();
            this.genero = row["genero"].ToString();
            this.f_nacimiento = row["f_nacimiento"].ToString();
            this.dni = row["dni"].ToString();
            this.correo = row["correo"].ToString();
            this.contraseña = row["contraseña"].ToString();

        }
        public User() { }
    }
}

namespace tarea0704.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string usuario { get; set; }
        public string genero { get; set; }
        public string f_nacimiento { get; set; }
        public string dni { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }

        public User(int id, string nombres, string apellidos, string usuario, string genero, string f_nacimiento, string dni, string correo, string contraseña)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            this.usuario = usuario;
            this.genero = genero;
            this.f_nacimiento = f_nacimiento;
            this.dni = dni;
            this.correo = correo;
            this.contraseña = contraseña;
        }
    }
}

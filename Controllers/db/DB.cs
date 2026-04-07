using System.Data;
using System.Data.SqlClient;
namespace tarea0704.Controllers.db
{
    public class DB
    {
        SqlConnection cn = new SqlConnection("");

        public DataTable EjecutarSQL(string sql, string[] parametros = null)
        {
            DataTable dt = new DataTable();
            if (parametros != null)
            {
                foreach (string param in parametros) {
                    sql += param;
                }

            }
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            da.Dispose();

            return dt;

        }
    }
}

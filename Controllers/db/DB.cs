using System.Data;
using System.Data.SqlClient;
namespace tarea0704.Controllers.db
{
    public class DB
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TareaCShard;Integrated Security=True;");

        public DataTable EjecutarSQL(string sql, string[] parametros = null)
        {
            DataTable dt = new DataTable();
            if (parametros != null)
            {
                sql += String.Join(",", parametros);
            }
            Console.Write(sql);
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

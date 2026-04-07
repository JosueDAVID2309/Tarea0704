using System.Data;
using System.Data.SqlClient;
namespace tarea0704.Controllers.db
{
    public class DB
    {
        SqlConnection cn = new SqlConnection("Data Source=8CGK1P111102A18;Integrated Security=True;Initial Catalog= TareaCShard ; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;");

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

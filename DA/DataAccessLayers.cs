using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DA;

namespace DA
{
    public class DataAccessLayers
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void connection() //connect to DataBase
        {
            con.ConnectionString = "";
            con.Open();
        }
        public void disconnect() //disconnect from DataBase
        {
            con.Close();
        }

        public DataTable select(String sql) //select table from DataBase
        {
            cmd.CommandText = sql;
            da.Fill(dt);
            return dt;
        }
        public void docommand(string sql) //Do query on table's of DataBase
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}

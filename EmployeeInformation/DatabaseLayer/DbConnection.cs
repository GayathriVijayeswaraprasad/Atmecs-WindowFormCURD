using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DatabaseLayer
{
    public class DbConnection
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DbConnection()
        {
            con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeInfo; Integrated Security = TrueData Source=localhost\SQLEXPRESS;Initial Catalog=EmployeeInfo;Integrated Security=True");
        }
        public DataTable CommonMethodSelection(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public int SetValueInDb(SqlParameter[] parameters,string procName)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(parameters);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public DataTable GetRecordUsingProc(string procName)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}

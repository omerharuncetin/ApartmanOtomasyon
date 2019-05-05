using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanOtomasyon2
{
    class SqlHelper
    {
        private string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public SqlHelper()
        {
            ConnectionString = @"Data Source=DESKTOP-VG6HM2E\SQLEXPRESS;Initial Catalog=APARTMAN;Integrated Security=True";
            Connection = new SqlConnection(ConnectionString);
        }
        public void ExecuteProc(string procName, params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps);
            command.Connection = Connection;

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query,ConnectionString);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }
        
    }
}

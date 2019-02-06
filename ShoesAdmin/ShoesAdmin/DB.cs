using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Web;

namespace ShoesAdmin
{
    public class DB
    {
        public static int modifyData(String query, List<SqlParameter> parameters)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DHRUMIL\MSSQLSERVERNEW;Initial Catalog=test1;Integrated Security=True";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = query;
            comm.Parameters.AddRange(parameters.ToArray());
            comm.Connection = conn;

            conn.Open();
            int x = comm.ExecuteNonQuery();
            conn.Close();

            return x;
        }
        public static DataTable ModifyData(String query, List<SqlParameter> parameters)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DHRUMIL\MSSQLSERVERNEW;Initial Catalog=test1;Integrated Security=True";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = query;
            comm.Parameters.AddRange(parameters.ToArray());
            comm.Connection = conn;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            conn.Open();
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }

    }
}
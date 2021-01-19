using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DrinkMenu.DataAccess.Concrete.ADONET
{
    public class VTYS
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DrinkDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static bool SqlExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static SqlDataReader SqlExecuteReader(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
    }
}

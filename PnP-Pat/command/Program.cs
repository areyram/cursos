using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace command
{
    class Program
    {
        static void Main()
        {
            Test();
        }

        private static void Test()
        {
            var conn = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            var cn = new SqlConnection(conn);
            var cmd = new SqlCommand("Employee Sales by Country", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Beginning_Date", new DateTime(1996, 1, 1));
            cmd.Parameters.AddWithValue("@Ending_Date", new DateTime(1996, 12, 31));
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //TODO: Process row
            }
        }
    }
}

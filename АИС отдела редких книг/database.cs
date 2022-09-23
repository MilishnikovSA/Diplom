using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АИС_отдела_редких_книг
{
    class database
    {
        public static string connectString = @"Data Source=DESKTOP1;Initial Catalog = AaDb; User ID = user1; Password=sa";
        public static SqlConnection Con;

        public static void OpenCon()
        {
            Con = new SqlConnection(connectString);
            Con.Open();
        }

        public static void CloseConnection()
        {
            Con.Close();
        }

        public static DataTable Load(string SqlQuery)
        {
            OpenCon();
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand(SqlQuery, Con);
            query.CommandType = CommandType.Text;
            SqlDataReader dr = query.ExecuteReader();
            dt.Load(dr);
            CloseConnection();
            return dt;
        }
    }
}

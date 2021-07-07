using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    static class SqlConnect
    {
        public static string get_cs()
        {
            return "Data Source=SALADCREATE; Initial Catalog = Storage; User ID = sa; Password = 123456";
        }

        public static string GetInfo(string request)
        {
            string result = String.Empty;
            using (var connection = new SqlConnection(get_cs()))
            {
                connection.Open();
                using (var cmd = new SqlCommand(request, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            result = rd.GetValue(0).ToString();
                        }
                    }
                }
                connection.Close();
            }
            return result;
        }

        public static void ChangeSomeArr(string request)
        {
            using (var connection = new SqlConnection(get_cs()))
            {
                connection.Open();
                using (var cmd = new SqlCommand(request, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeShopProject {
    public static class DBQueryHelper {
        public static SqlConnection connection = Form1.con;

        public static void OpenConnection() {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
        }

        public static void CloseConnection() {
            if (connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
            }
        }
        public static void Insert_TblTransaction(TblTransaction record) {
            using (var cmd = new SqlCommand("", connection)) {
                if (connection.State != System.Data.ConnectionState.Open)
                    return;
                cmd.CommandText = "INSERT INTO TblTransaction(TransID, TransDate) VALUES (@TID, @date)";
                cmd.Parameters.AddWithValue("@TID", record.TransID);
                cmd.Parameters.AddWithValue("@date", record.TransDate);
                
                cmd.ExecuteNonQuery();
            }
        }

        public static void Insert_TblTransItem(TblTransItem record) {
            using (var cmd = new SqlCommand("", connection)) {
                if (connection.State != System.Data.ConnectionState.Open)
                    return;
                cmd.CommandText = "INSERT INTO TblTransItem(TransID, ProductID, ProductCount) VALUES (@TID, @PID, @Count)";
                cmd.Parameters.AddWithValue("@TID", record.TransID);
                cmd.Parameters.AddWithValue("@PID", record.ProductID);
                cmd.Parameters.AddWithValue("@Count", record.ProductCount);

                cmd.ExecuteNonQuery();
            }
        }

        public static string GenerateTransID() {
            return Guid.NewGuid().ToString("N");
        }
    }
}

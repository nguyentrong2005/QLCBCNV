using System;
using System.Data;
using System.Data.SqlClient;

namespace QLTH_BTNhom
{
    internal class DatabaseHelper
    {
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("✅ Kết nối SQL Server thành công!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi kết nối: " + ex.Message);
                return false;
            }
        }

        private string connectionString;

        // Constructor cho phép dùng chuỗi kết nối mặc định hoặc tùy chỉnh
        public DatabaseHelper(string connStr = "Server=.;Database=QLCBCNV;Integrated Security=True")
        {
            connectionString = connStr;
        }

        // Mở kết nối SQL
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Thực thi lệnh INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi
            }
        }

        // Trả về giá trị đơn (ví dụ: COUNT(*))
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return null;
            }
        }

        // Trả về bảng dữ liệu (SELECT)
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return null;
            }
        }
    }
}
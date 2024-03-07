using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DAL
    {
        // Chuỗi kết nối
        string ConnStr = @"Data Source=(local)\SQLEXPRESS;
                           Initial Catalog=QuanLyKhachSan;
                           Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        // Thiết lập kết nối và chuẩn bị command
        public DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        // Phương thức lấy dữ liệu
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct; // mặc định là Text
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet ExecuteQueryDataSetFilter(string strSQL, CommandType ct,
            params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Xóa các tham số cũ trước khi thêm tham số mới
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct; // mặc định là Text

            // Dựa vào các tham số để thực thi phương thức
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public string MyExecuteScalar(string strSQL, CommandType ct, 
            params SqlParameter[] param)
        {
            string result;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Xóa các tham số cũ trước khi thêm tham số mới
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct; // mặc định là Text

            // Dựa vào các tham số để thực thi phương thức
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            result = comm.ExecuteScalar().ToString();
            conn.Close();
            return result;
        }

        // Thực thi các action query
        // (Insert/delete/update/StoredProcedure)
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, 
            ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Xóa các tham số cũ trước khi thêm tham số mới
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            // Dựa vào các tham số để thực thi stored procedure
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}

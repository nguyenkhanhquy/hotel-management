using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBLoaiPhong
    {
        DAL db = null;
        public DBLoaiPhong()
        {
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemLoaiPhong(ref string err,
            string MaLoaiPhong, string TenLoaiPhong, string GiaPhong)
        {
            return db.MyExecuteNonQuery("spThemLoaiPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("@TenLoaiPhong", TenLoaiPhong),
                new SqlParameter("@GiaPhong", GiaPhong));
        }

        // SELECT - R
        public DataSet LayLoaiPhong()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM LoaiPhong", CommandType.Text);
        }

        public string LayGiaPhong(string MaLoaiPhong)
        {
            return db.MyExecuteScalar(
                "SELECT GiaPhong FROM LoaiPhong WHERE MaLoaiPhong = @MaLoaiPhong",
                CommandType.Text,
                new SqlParameter("@MaLoaiPhong", MaLoaiPhong));
        }

        // UPDATE - U
        public bool CapNhatLoaiPhong(ref string err,
            string MaLoaiPhong, string TenLoaiPhong, string GiaPhong)
        {
            return db.MyExecuteNonQuery("spCapNhatLoaiPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("@TenLoaiPhong", TenLoaiPhong),
                new SqlParameter("@GiaPhong", GiaPhong));
        }

        // DELETE - D
        public bool XoaLoaiPhong(ref string err, string MaLoaiPhong)
        {
            return db.MyExecuteNonQuery("spXoaLoaiPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiPhong", MaLoaiPhong));
        }
    }
}

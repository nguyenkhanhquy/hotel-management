using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBNhanVien
    {
        DAL db = null;
        public DBNhanVien()
        {
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemNhanVien(ref string err,
            string MaNhanVien, string TenNhanVien, string CCCD, string NgaySinh,
            string GioiTinh, string DienThoai)
        {
            return db.MyExecuteNonQuery("spThemNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@TenNhanVien", TenNhanVien),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DienThoai", DienThoai));
        }

        // SELECT - R
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM NhanVien", CommandType.Text);
        }

        public DataSet LocNhanVien(
            string MaNhanVien, string TenNhanVien, string CCCD, string NgaySinh,
            string GioiTinh, string DienThoai)
        {
            return db.ExecuteQueryDataSetFilter("spLocNhanVien",
                CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@TenNhanVien", TenNhanVien),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DienThoai", DienThoai));
        }

        // UPDATE - U
        public bool CapNhatNhanVien(ref string err,
            string MaNhanVien, string TenNhanVien, string CCCD, string NgaySinh,
            string GioiTinh, string DienThoai)
        {
            return db.MyExecuteNonQuery("spCapNhatNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@TenNhanVien", TenNhanVien),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DienThoai", DienThoai));
        }

        // DELETE - D
        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            return db.MyExecuteNonQuery("spXoaNhanVien",
                CommandType.StoredProcedure, ref err, 
                new SqlParameter("@MaNhanVien", MaNhanVien));
        }
    }
}

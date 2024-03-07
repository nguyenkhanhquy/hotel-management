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
    public class DBKhachHang
    {
        DAL db = null;
        public DBKhachHang()
        {
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemKhachHang(ref string err,
            string MaKhachHang, string TenKhachHang, string CCCD, string NgaySinh,
            string GioiTinh, string DienThoai, string MaThanhPho)
        {
            return db.MyExecuteNonQuery("spThemKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhachHang", MaKhachHang),
                new SqlParameter("@TenKhachHang", TenKhachHang),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@MaThanhPho", MaThanhPho));
        }

        // SELECT - R
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM KhachHang", CommandType.Text);
        }

        public DataSet LocKhachHang(
            string MaKhachHang, string TenKhachHang, string CCCD, string NgaySinh,
            string GioiTinh, string DienThoai, string MaThanhPho)
        {
            return db.ExecuteQueryDataSetFilter("spLocKhachHang",
                CommandType.StoredProcedure,
                new SqlParameter("@MaKhachHang", MaKhachHang),
                new SqlParameter("@TenKhachHang", TenKhachHang),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@MaThanhPho", MaThanhPho));
        }

        // UPDATE - U
        public bool CapNhatKhachHang(ref string err,
            string MaKhachHang, string TenKhachHang, string CCCD, string NgaySinh,
            string GioiTinh, string DienThoai, string MaThanhPho)
        {
            return db.MyExecuteNonQuery("spCapNhatKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhachHang", MaKhachHang),
                new SqlParameter("@TenKhachHang", TenKhachHang),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@MaThanhPho", MaThanhPho));
        }

        // DELETE - D
        public bool XoaKhachHang(ref string err, string MaKhachHang)
        {
            return db.MyExecuteNonQuery("spXoaKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhachHang", MaKhachHang));
        }
    }
}

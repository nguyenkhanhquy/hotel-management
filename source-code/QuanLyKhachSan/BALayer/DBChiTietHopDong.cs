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
    public class DBChiTietHopDong
    {
        DAL db = null;
        public DBChiTietHopDong()
        {
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemChiTietHopDong(ref string err,
            string MaHopDong, string MaNhanVien, string MaKhachHang, string NgayVao,
            string SoNgayThue, string SoLuongPhongThue, string TongTien, string TinhTrangThanhToan)
        {
            return db.MyExecuteNonQuery("spThemChiTietHopDong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHopDong", MaHopDong),
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@MaKhachHang", MaKhachHang),
                new SqlParameter("@NgayVao", NgayVao),
                new SqlParameter("@SoNgayThue", SoNgayThue),
                new SqlParameter("@SoLuongPhongThue", SoLuongPhongThue),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@TinhTrangThanhToan", TinhTrangThanhToan));
        }

        // SELECT - R
        public DataSet LayChiTietHopDong()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM ChiTietHopDong", CommandType.Text);
        }

        public string LayTinhTrangThanhToan(string MaHopDong)
        {
            return db.MyExecuteScalar(
                "SELECT TinhTrangThanhToan FROM ChiTietHopDong WHERE MaHopDong = @MaHopDong",
                CommandType.Text,
                new SqlParameter("@MaHopDong", MaHopDong));
        }

        public string LayTongTien(string MaHopDong)
        {
            return db.MyExecuteScalar(
                "SELECT TongTien FROM ChiTietHopDong WHERE MaHopDong = @MaHopDong",
                CommandType.Text,
                new SqlParameter("@MaHopDong", MaHopDong));
        }

        // UPDATE - U
        public bool CapNhatChiTietHopDong(ref string err,
            string MaHopDong, string SoNgayThue)
        {
            return db.MyExecuteNonQuery("spCapNhatChiTietHopDong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHopDong", MaHopDong),
                new SqlParameter("@SoNgayThue", SoNgayThue));
        }

        public bool CapNhatTongTien(ref string err,
            string MaHopDong, string TongTien)
        {
            return db.MyExecuteNonQuery("spCapNhatTongTien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHopDong", MaHopDong),
                new SqlParameter("@TongTien", TongTien));
        }

        public bool CapNhatTinhTrangThanhToan(ref string err,
            string MaHopDong)
        {
            return db.MyExecuteNonQuery("spCapNhatTinhTrangThanhToan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHopDong", MaHopDong));
        }

        public bool CapNhatSoPhongThue(ref string err,
            string MaHopDong)
        {
            return db.MyExecuteNonQuery("spCapNhatSoPhongThue",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHopDong", MaHopDong));
        }
    }
}

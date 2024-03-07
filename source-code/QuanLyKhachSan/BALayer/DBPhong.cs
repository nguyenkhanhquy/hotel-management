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
    public class DBPhong
    {
        DAL db = null;
        public DBPhong()
        {
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemPhong(ref string err, 
            string MaPhong, string MaLoaiPhong, string SoPhong, string SoLuongNguoi, 
            string PhongTrong)
        {
            return db.MyExecuteNonQuery("spThemPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhong", MaPhong),
                new SqlParameter("@MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("@SoPhong", SoPhong),
                new SqlParameter("@SoLuongNguoi", SoLuongNguoi),
                new SqlParameter("@PhongTrong", PhongTrong));
        }

        // SELECT - R
        public DataSet LayPhong()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM Phong", CommandType.Text);
        }

        public string LayTinhTrangPhongTrong(string MaPhong)
        {
            return db.MyExecuteScalar(
                "SELECT PhongTrong FROM Phong WHERE MaPhong = @MaPhong",
                CommandType.Text,
                new SqlParameter("@MaPhong", MaPhong));
        }

        public DataSet LayPhongTheoHopDong(string MaHopDong)
        {
            return db.ExecuteQueryDataSetFilter(
                "SELECT * FROM Phong WHERE MaHopDong = @MaHopDong", 
                CommandType.Text,
                new SqlParameter("@MaHopDong", MaHopDong));
        }

        public string KiemTraTonTai()
        {
            return db.MyExecuteScalar(
                "SELECT COUNT(*) FROM Phong WHERE PhongTrong = '1'",
                CommandType.Text);
        }

        // UPDATE - U
        public bool CapNhatPhong(ref string err,
            string MaPhong, string MaLoaiPhong, string SoPhong, string SoLuongNguoi)
        {
            return db.MyExecuteNonQuery("spCapNhatPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhong", MaPhong),
                new SqlParameter("@MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("@SoPhong", SoPhong),
                new SqlParameter("@SoLuongNguoi", SoLuongNguoi));
        }

        public bool CapNhatTinhTrangPhongThue(ref string err,
            string MaHopDong)
        {
            return db.MyExecuteNonQuery("spCapNhatTinhTrangPhongThue",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHopDong", MaHopDong));
        }

        public bool CapNhatMaHopDong(ref string err,
            string MaPhong, string MaHopDong)
        {
            return db.MyExecuteNonQuery("spCapNhatMaHopDong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhong", MaPhong),
                new SqlParameter("@MaHopDong", MaHopDong));
        }

        // DELETE - D
        public bool XoaPhong(ref string err, string MaPhong)
        {
            return db.MyExecuteNonQuery("spXoaPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhong", MaPhong));
        }
    }
}

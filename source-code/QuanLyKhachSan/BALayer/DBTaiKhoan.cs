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
    public class DBTaiKhoan
    {
        DAL db = null;
        public DBTaiKhoan() 
        { 
            db = new DAL();
        }

        public string KiemTraTonTai(string TenDangNhap)
        {
            return db.MyExecuteScalar(
                "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap",
                CommandType.Text,
                new SqlParameter("@TenDangNhap", TenDangNhap));    
        }

        public string LayMatKhau(string TenDangNhap)
        {
            return db.MyExecuteScalar(
                "SELECT MatKhau FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap",
                CommandType.Text,
                new SqlParameter("@TenDangNhap", TenDangNhap));
        }

        public bool ThemTaiKhoan(ref string err,
            string TenDangNhap, string MatKhau) 
        { 
            return db.MyExecuteNonQuery("spThemTaiKhoan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@MatKhau", MatKhau));
        }

        public bool DoiMatKhau(ref string err,
            string TenDangNhap, string MatKhau)
        {
            return db.MyExecuteNonQuery("spDoiMatKhau",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@MatKhau", MatKhau));
        }

        public bool XoaTaiKhoan(ref string err,
            string TenDangNhap)
        {
            return db.MyExecuteNonQuery("spXoaTaiKhoan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDangNhap", TenDangNhap));
        }
    }
}

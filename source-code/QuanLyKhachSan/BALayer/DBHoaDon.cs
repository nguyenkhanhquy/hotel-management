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
    public class DBHoaDon
    {
        DAL db = null;
        public DBHoaDon()
        {
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemHoaDon(ref string err,
            string MaHoaDon, string MaHopDong, string TongTien, string NgayThanhToan)
        {
            return db.MyExecuteNonQuery("spThemHoaDon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@MaHopDong", MaHopDong),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@NgayThanhToan", NgayThanhToan));
        }

        // SELECT - R
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM HoaDon", CommandType.Text);
        }
    }
}

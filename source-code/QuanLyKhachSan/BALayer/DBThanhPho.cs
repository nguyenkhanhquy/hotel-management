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
    public class DBThanhPho
    {
        DAL db = null;
        public DBThanhPho() 
        { 
            db = new DAL();
        }

        // Các phương thức CRUD
        // INSERT - C
        public bool ThemThanhPho(ref string err,
            string MaThanhPho, string TenThanhPho)
        {
            return db.MyExecuteNonQuery("spThemThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaThanhPho", MaThanhPho),
                new SqlParameter("@TenThanhPho", TenThanhPho));
        }

        // SELECT - R
        public DataSet LayThanhPho()
        {
            return db.ExecuteQueryDataSet(
                "SELECT * FROM ThanhPho", CommandType.Text);
        }

        // UPDATE - U
        public bool CapNhatThanhPho(ref string err,
            string MaThanhPho, string TenThanhPho)
        {
            return db.MyExecuteNonQuery("spCapNhatThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaThanhPho", MaThanhPho),
                new SqlParameter("@TenThanhPho", TenThanhPho));
        }

        // DELETE - D
        public bool XoaThanhPho(ref string err, string MaThanhPho)
        {
            return db.MyExecuteNonQuery("spXoaThanhPho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaThanhPho", MaThanhPho));
        }
    }
}

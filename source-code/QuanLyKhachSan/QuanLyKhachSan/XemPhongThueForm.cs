using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class XemPhongThueForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtPhong = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLoaiPhong = null;

        // Khai báo biến lưu mã hợp đồng
        private string strMaHopDong;

        DBPhong dbP;
        DBLoaiPhong dbLP;

        public XemPhongThueForm(string maHopDong)
        {
            InitializeComponent();
            strMaHopDong = maHopDong;

            dbP = new DBPhong();
            dbLP = new DBLoaiPhong();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu vào DataTable dtLoaiPhong
                dtLoaiPhong = new DataTable();
                dtLoaiPhong.Clear();
                dtLoaiPhong = dbLP.LayLoaiPhong().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaLoaiPhong.DataSource = dtLoaiPhong;
                MaLoaiPhong.DisplayMember = "TenLoaiPhong";
                MaLoaiPhong.ValueMember = "MaLoaiPhong";

                // Vận chuyển dữ liệu lên DataTable dtPhong
                dtPhong = new DataTable();
                dtPhong.Clear();
                dtPhong = dbP.LayPhongTheoHopDong(strMaHopDong).Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvPhong.DataSource = dtPhong;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table Phong",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XemPhongThueForm_Load(object sender, EventArgs e)
        {
            txtMaHopDong.Text = strMaHopDong;
            LoadData();
        }

        private void XemPhongThueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtPhong.Dispose();
            dtPhong = null;
            dtLoaiPhong.Dispose();
            dtLoaiPhong = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn muốn thoát không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Yes không?
            if (traloi == DialogResult.Yes) Close();
        }
    }
}

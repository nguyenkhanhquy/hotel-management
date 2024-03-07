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
    public partial class DanhMucChiTietHopDongForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtChiTietHopDong = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtNhanVien = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;

        DBChiTietHopDong dbCTHD;
        DBNhanVien dbNV;
        DBKhachHang dbKH;

        public DanhMucChiTietHopDongForm()
        {
            InitializeComponent();
            dbCTHD = new DBChiTietHopDong();
            dbNV = new DBNhanVien();
            dbKH = new DBKhachHang();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu lên DataTable dtNhanVien
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNV.LayNhanVien().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaNhanVien.DataSource = dtNhanVien;
                MaNhanVien.DisplayMember = "TenNhanVien";
                MaNhanVien.ValueMember = "MaNhanVien";

                // Vận chuyển dữ liệu lên DataTable dtKhachHang
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbKH.LayKhachHang().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaKhachHang.DataSource = dtKhachHang;
                MaKhachHang.DisplayMember = "TenKhachHang";
                MaKhachHang.ValueMember = "MaKhachHang";

                // Vận chuyển dữ liệu lên DataTable dtChiTietHopDong
                dtChiTietHopDong = new DataTable();
                dtChiTietHopDong.Clear();
                dtChiTietHopDong = dbCTHD.LayChiTietHopDong().Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvChiTietHopDong.DataSource = dtChiTietHopDong;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table KhachHang",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhMucChiTietHopDongForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DanhMucChiTietHopDongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtChiTietHopDong.Dispose();
            dtChiTietHopDong = null;
            dtNhanVien.Dispose();
            dtNhanVien = null;
            dtKhachHang.Dispose();
            dtKhachHang = null;
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

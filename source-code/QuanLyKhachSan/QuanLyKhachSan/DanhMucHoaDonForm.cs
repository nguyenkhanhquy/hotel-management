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
    public partial class DanhMucHoaDonForm : Form
    {
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtHoaDon = null;

        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtHopDong = null;

        DBHoaDon dbHD;
        DBChiTietHopDong dbCTHD;
        public DanhMucHoaDonForm()
        {
            InitializeComponent();
            dbHD = new DBHoaDon();
            dbCTHD = new DBChiTietHopDong();
        }

        void LoadData()
        {
            try
            {
                // Vận chuyển dữ liệu lên DataTable dtHopDong
                dtHopDong = new DataTable();
                dtHopDong.Clear();
                dtHopDong = dbCTHD.LayChiTietHopDong().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView 
                MaHopDong.DataSource = dtHopDong;
                MaHopDong.DisplayMember = "MaHopDong";
                MaHopDong.ValueMember = "MaHopDong";

                // Vận chuyển dữ liệu lên DataTable dtHoaDon
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                dtHoaDon = dbHD.LayHoaDon().Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvHoaDon.DataSource = dtHoaDon;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu trong table HoaDon",
                    "Lỗi lấy dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhMucHoaDonForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DanhMucHoaDonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtHoaDon.Dispose();
            dtHoaDon = null;
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
